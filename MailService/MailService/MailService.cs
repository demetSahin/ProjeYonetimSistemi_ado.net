using System;
using System.Configuration;
using System.Net.Mail;
using System.Net;
using System.ServiceProcess;
using System.Timers;

namespace MailService
{
    public partial class MailService : ServiceBase
    {
        System.Timers.Timer timer;
        int strTime, getCallType;

        public MailService()
        {
            InitializeComponent();
            strTime = Convert.ToInt32(ConfigurationManager.AppSettings["callDuration"]); //Çağrı süresi
            getCallType = Convert.ToInt32(ConfigurationManager.AppSettings["CallType"]); //Çağrı tipi

            if (getCallType == 1)
            {
                timer = new System.Timers.Timer(); 
                double inter = (double)GetNextInterval();
                timer.Interval = inter;
                timer.Elapsed += new ElapsedEventHandler(ServiceTimer_Tick);
            }
            else
            {
                timer = new System.Timers.Timer();
                timer.Interval = strTime * 1000;
                timer.Elapsed += new ElapsedEventHandler(ServiceTimer_Tick);
            }
        }

        protected override void OnStart(string[] args) // Servis çalıştığında bu metotdun içindeki kodlar çalıştırılır.
        {
            timer.AutoReset = true;
            timer.Enabled = true; //Timer aktif ediliyor.
        }

        protected override void OnStop() //Servis durduğunda bu metodun içindeki kodlar çalıştırılır.
        {
            timer.AutoReset = false;
            timer.Enabled = false; //Timer durduruluyor.
        }

        private double GetNextInterval() //Zaman aralığı değeri oluşturuluyor.
        {
            String timeString = ConfigurationManager.AppSettings["StartTime"];
            DateTime t = DateTime.Parse(timeString);
            TimeSpan ts;
            ts = t - System.DateTime.Now;
            if (ts.TotalMilliseconds < 0)
            {
                ts = t.AddDays(1) - System.DateTime.Now;
            }
            return ts.TotalMilliseconds;
        }
        private void SetTimer()
        {
            try
            {
                double inter = (double)GetNextInterval();
                timer.Interval = inter;
                timer.Start();
            }
            catch (Exception ex)
            {
            }
        }

        public void SendEmail()
        {
            using (MailMessage mm = new MailMessage("demetyenigul3@gmail.com", "demetyenigul3@gmail.com"))
            {
                mm.Subject = "Mail Subject";
                mm.Body = "Mail Body";
                mm.IsBodyHtml = false;
                using (SmtpClient sc = new SmtpClient("smtp.gmail.com", 25))
                {
                    sc.EnableSsl = true;
                    sc.DeliveryMethod = SmtpDeliveryMethod.Network;
                    sc.UseDefaultCredentials = false;
                    sc.Credentials = new NetworkCredential("demetyenigul3@gmail.com", "******");
                    sc.Send(mm);
                }
            }
        }

        private void ServiceTimer_Tick(object sender, System.Timers.ElapsedEventArgs e)
        {
            SendEmail();

            if (getCallType == 1)
            {
                timer.Stop();
                System.Threading.Thread.Sleep(1000);
                SetTimer();
            }
        }
    }
}
