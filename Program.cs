using System;

namespace Pertemuan_8
{
    public class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public Person(string name, int age)
        {
            Name = name;
            Age = age;
        }

        public virtual void InfoPerson()
        {
            Console.WriteLine("Nama saya {0}, dan Umur saya {1} tahun", Name, Age);
        }
    }

    public class Karyawan : Person
    {
        public string KaryawanID { get; set; }
        public string Subject { get; set; }

        public Karyawan(string name, int age, string karyawanID, string subject) 
            : base(name, age)
        {
            KaryawanID = karyawanID;
            Subject = subject;
        }

        public override void InfoPerson()
        {
            Console.WriteLine("Nama saya {0}, dan Umur saya {1} tahun", Name, Age);
            Console.WriteLine("Karyawan ID : {0}, dengan Subject : {1}", KaryawanID, Subject);
        }

    }

    public class Program
    { 
        static void Main(string[] args)
        {
        Person person1 = new Person("Fattaah Herdansyah", 19);
        person1.InfoPerson();

        Karyawan karyawanID = new Karyawan("Fattaah Herdansyah", 19, "K010", "Dosen");
            karyawanID.InfoPerson();
        }
    }
}
