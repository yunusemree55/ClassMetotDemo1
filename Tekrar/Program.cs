using System;

namespace Tekrar
{
    class Program
    {
        static void Main(string[] args)
        {

            //Müşteri Bilgileri

            Client client1 = new Client();
            client1.Name = "Yunus Emre";
            client1.Surname = "Çiçek";
            client1.Id = 43251;

            Client client2 = new Client();
            client2.Name = "Furkan";
            client2.Surname = "Acar";
            client2.Id = 64820;

            Client client3 = new Client();
            client3.Name = "Mert Ali";
            client3.Surname = "Işık";
            client3.Id = 85931;

            // Müşteri Listesi
            Client[] clients = new Client[] { client1, client2, client3 };

            MusteriManager musteriManager = new MusteriManager();



            //    << Müşteri Listeleme >>

            foreach (var client in clients)
            {
                musteriManager.Listele(client);
            }


            

            //    << Müşteri Ekleme >>

            foreach (Client client in clients)
            {
                musteriManager.Ekle(client);
            }




            //    << Müşteri Silme >> 

            foreach (Client client in clients)
            {
                musteriManager.Silme(client);
            }

        }
    }
}
