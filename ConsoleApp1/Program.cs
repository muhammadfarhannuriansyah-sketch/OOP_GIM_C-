using System;
using System.Security.Cryptography.X509Certificates;
namespace KerangkaGame
{
    class Karakter 
    {
        public int totalSenjata, power;

        //encapsulation
        public string nama{ get; private set; }
        public int Kesehatan { get; private set; }
        public int senjata { get; private set; }

        public Karakter(string nama, int kesehatan, int senjata)
        {
            this.nama = nama;
            this.Kesehatan = kesehatan;
            this.senjata = senjata;
        }

        public void Serang(Karakter target)//membuat method serang
        {
            Console.WriteLine("===> Mulai Serang");
            target.TerimaSerangan(this.senjata);
        }

        public void TerimaSerangan(int jumlahSerangan)//objek menerima serangan
        {
            Console.WriteLine("===> Mulai Terima Serangan");
            this.Kesehatan -= jumlahSerangan;
            Console.WriteLine($"{nama} diserang dengan {jumlahSerangan}. Sisa kesehatan {Kesehatan}");
        }
        //public void setNama(string namaBaru)
        //{
        //    this.nama = namaBaru;
        //}

        //public void setKesehatan(int kesehatanBaru)
        //{
        //    this.Kesehatan = kesehatanBaru;
        //}

        //public void setSenjata(string senjataBaru)
        //{
        //    this.senjata = senjataBaru;
        //}

        //public void setTotalSenjata(int totalSenjata)
        //{
        //    this.totalSenjata = totalSenjata;
        //}

        //public void setPower(int power)
        //{
        //    this.power = power;
        //}

        //public void getNama()
        //{
        //    Console.WriteLine("Nama : " + nama);
        //}

        //public void getKesehatan()
        //{
        //    Console.WriteLine("Kesehatan : " + Kesehatan);
        //}

        //public void getSenjata()
        //{
        //    Console.WriteLine("Senjata : " + senjata);
        //}

        //public void getTotalSenjata()
        //{
        //    Console.WriteLine("Total Senjata : " + totalSenjata);
        //}

        //public void getPower()
        //{
        //    Console.WriteLine("Power : " + power);
        //}

        public void getData()
        {
            Console.WriteLine($"Nama : {nama}");//menggunakan string interpolation
            Console.WriteLine($"Kesehatan : {Kesehatan}");//menggunakan string interpolation
            Console.WriteLine($"Senjata : {senjata}");//menggunakan string interpolation
        }
    }

    class MainProgram
    {
        static void Main(string[] args)
        {
            Karakter player1 = new Karakter("RianSyah", 100, 25);
            Karakter musuh = new Karakter("Keki", 100, 25);

            //interaksi
            player1.Serang(musuh);
            musuh.getData();

            ////kode pertemuan sebelumnya
            //List<Karakter> daftarHero = new List<Karakter>(); //array menyimpan pahlawan
            //Karakter player1 = new Karakter(); //player disini sebagi objeck
            //player1.setNama("Archer");
            ////player.getNama();
            //player1.setKesehatan("sehat");
            ////player.getKesehatan();
            //player1.setSenjata("Demon Sword");
            ////player.getSenjata();
            //player1.setTotalSenjata(5);
            ////player.getTotalSenjata();
            //player1.setPower(25);
            ////player.getPower();

            //Console.WriteLine("==================");

            //Karakter player2 = new Karakter();
            //player2.setNama("Golem");
            ////player2.getNama();
            //player2.setKesehatan("Kritis");
            ////player2.getKesehatan();
            //player2.setSenjata("Tinju Super");
            ////player2.getSenjata();
            //player2.setTotalSenjata(1);
            ////player2.getTotalSenjata();
            //player2.setPower(50);
            ////player2.getPower();

            //Console.WriteLine("==================");

            //Karakter Musuh = new Karakter();
            //Musuh.setNama("Skeleton");
            ////Musuh.getNama();
            //Musuh.setKesehatan("sehat");
            ////Musuh.getKesehatan();
            //Musuh.setSenjata("Panah");
            ////Musuh.getSenjata();
            //Musuh.setTotalSenjata(3);
            ////Musuh.getTotalSenjata();
            //Musuh.setPower(25);
            ////Musuh.getPower();

            //daftarHero.Add(player1);
            //daftarHero.Add(player2);
            //daftarHero.Add(Musuh);

            ////menampilkan data dari array, foreach
            //foreach(Karakter player in daftarHero)
            //{
            //    player.getNama();
            //    player.getKesehatan();
            //    player.getSenjata();
            //    player.getTotalSenjata();
            //    player.getPower();
            //}
        }
    }
}