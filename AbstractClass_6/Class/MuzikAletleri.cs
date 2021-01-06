using AbstractClass_6.Class;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClass_6
{
     abstract class MuzikAletleri //Class'ımızın abs tanımlanması gerekli unutma,abs yapılar ancak,abs Class içinde bulunur.
    {
        //Abstract(Soyut): sadece miras verilmek için tasarlanmış Class'lardır.
        //Abstract kavramı Class'a özel bir durum değildir prop,method  gibi bir eleman abs olablir.
        //Bir metodun Virtual olması istersen ezip kullan,istersen aynen kullan demektir.
        //Ama bi yapının Abs olması o yapıyı(Miras alan sınıflarda) zorunlu olarak ezerek kullancaksın demek oluyor.
        //Abs methodların gövdesi olmaz,abs işaretlenen yapı zaten miras verildiği taktirde ezilmek zorundadır,gövdesinin olmasının hiç bir anlamı yok..
        //Class Abs değilse eğer,içerisinde Abs yapı bulunduramaz
        //Abs Class içinde,Abs olmayan yapılarda ola bilir.Abs değilse gövdesi olmalı
        //Abs bir Class'dan instance alınamaz,Derleme zamanı hatası yaşanır
        //Abs Class İnterface'ye göre daha esnek yapıya sahiptir yarı zorlayıcıdır.
        //Abs Class'ın tek amacı Miras vermektir
        //Bir class sadece miras verilmek için oluşturuluyorsa Abs olarak tanımlamak doğru olacaktır
        //Abs tipli bir Field tanımlanamaz
        public virtual void M()
        {

        }
        public abstract string Cal();
        public string Ses { get; set; }
        public string Mensei { get; set; }
        public DateTime UretimTarihi { get; set; }
        public abstract CalmaTuru CalmaSekli { get; set; }
        private MuzikAletleri()
        {
          
        }


    }
}
