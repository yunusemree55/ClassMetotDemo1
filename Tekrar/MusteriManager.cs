using System;
using System.Collections.Generic;
using System.Text;

namespace Tekrar
{
    class MusteriManager
    {
        public void Ekle(Client client)
        {
            Console.WriteLine("Sitemize Hoşgeldiniz " + client.Name + " " + client.Surname);
        }

        public void Listele(Client client)
        {

            Console.WriteLine("-----Müşteri Bilgisi------");
            Console.WriteLine("Username: " + client.Name);
            Console.WriteLine("Surname: " + client.Surname);
            Console.WriteLine("ID: " + client.Id);
            Console.WriteLine("--------------------------------");

        }

        public void Silme(Client client)
        {
            Console.WriteLine("Hesabınız silindi " + client.Name + " " + client.Surname);

        }
    }
}
