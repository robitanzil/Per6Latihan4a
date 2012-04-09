using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Per6Latihan4a
{
    class OrangTua
    {
        public int Umur { get; set; }

        // cons
        public OrangTua(int Umur)
        {
            this.Umur = Umur;
        }
        
        
        
        public virtual void Mabuk()
        {
            Console.WriteLine("Saya Pemabuk");
        }
    }
}
