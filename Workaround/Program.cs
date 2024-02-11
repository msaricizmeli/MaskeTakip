using Business.Concrete;
using Entities.Concrete;
using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Degiskenler();

            Vatandas vatandas1 = new Vatandas();

            Person person1 = new Person();
            person1.FirstName = "Mert";
            person1.LastName = "sarıçizmeli";
            person1.DateOfBirthYear = 1999;
            person1.NationalIdentity = 12345678910;

           


            PttManager pttManager = new PttManager(new PersonManager());
            pttManager.GiveMask(person1);

            Console.ReadLine();
           
        }

        static void SelamVer() {
            Console.WriteLine("merhba");
        }

        private static void Degiskenler()
        {
            string ad = "mert";
            string soyad = "sarıçizmeli";
            int dogumYili = 1999;
            long tcNo = 12345678910;

            

            Console.WriteLine(ad);
        }
    }

    class Vatandas
    {
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public int DogumYili { get; set; }
        public long TcNo { get; set; }

    }
}