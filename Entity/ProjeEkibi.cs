using System.Collections.Generic;

namespace pys.Entity
{
    public class ProjeEkibi
    {
        public int ID { get; set; } //EF tarafından otomatik olarak primary key olarak atanır.
        public List<Kisi> projeEkibi { get; set; }
    }
}

