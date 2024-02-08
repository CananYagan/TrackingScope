using Entities.Concrete;
using System;

class ProgramGeneralNotes
{
    static void Main(string[] args)
    {
        Variables();
        Citizen citizen = new Citizen();  //Instance --Bir adet vatandaş oluşturdum :)
        //citizen. Burda birşey gelmez sebebi metodun içindeki değişkenler public değildi
        // Person person=new Person(); Entities classında public olduğu için burada import edilebilir.
    }

    private static void Variables()
    {
        Console.WriteLine("Hello, World!");

        string message = "Merhaba";
        Console.WriteLine(message);
        double amount = 100000;  //db den gelir.
        int number = 100;
        bool login = false;

        string name = "Canan";
        string surname = "Bektaş";
        int birtday = 1991;
        long tcNo = 123345678912;  //OOP:Nesne mantıksal gruplama yapar.  //Süslü Parantez:Block


        Console.WriteLine(amount * 1.18);
        Console.ReadLine();
    }

    //Büyük harfle başlaması Pascal Case
    class Citizen
    {
        //public string name = "Canan";
        //public string surname = "Bektaş";
        //public int birtday = 1991;
        //public long tcNo = 123345678912;
        public string Name { get; set; }
        public string Surname { get; set; }
        public int Birtday { get; set; }
        public long TcNo { get; set; }
    }

}



