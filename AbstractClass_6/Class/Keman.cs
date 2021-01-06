using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AbstractClass_6.Class;

namespace AbstractClass_6
{
    class Keman : MuzikAletleri
    {
        public override CalmaTuru CalmaSekli
        {
            get
            {
                return CalmaTuru.TelliCalma;
            }
            set => throw new NotImplementedException();
        }

      
        
    }
}
