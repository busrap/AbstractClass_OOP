using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClass_6.Class
{
    class Bateri : MuzikAletleri
    {
        public override CalmaTuru CalmaSekli
        {
            get
            {
                return CalmaTuru.VurmalıClama;
            }
            set => throw new NotImplementedException();
        }

        public override string Cal()
        {
            return "Bateri çalıyor...";
        }
    }
}
