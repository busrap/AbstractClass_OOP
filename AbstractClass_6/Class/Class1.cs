using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClass_6.Class
{
    class Class1 : MuzikAletleri
    {
        public override CalmaTuru CalmaSekli { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public override string Cal()
        {
            throw new NotImplementedException();
        }
      
    }
}
