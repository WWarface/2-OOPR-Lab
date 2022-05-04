using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_laba_oop
{
    public delegate void TouristHandler(string path);
    public sealed class Tourist: Human, IAgencyInfo
    {
        public Tourist() : base("Clone", "Clone", 0)
        {
            Voucher = new Voucher();
            Count++;
        }

        public Tourist(string name, string surname, int age) : base(name, surname, age)
        {           
            Count++;
            Tour = delegate (string path)
            {
            };
        }
        public static int Count { get; set; }

        public int Id { get; set; }

        public int Nationality { get; set; }

        private TouristHandler Tour;

        private static int k = 0;
        public static string Path { get; set; }
        public Voucher Voucher { get; set; }//Навігаційна властивість
        public CreditCard Card { get; set; }
        public string Label { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public IAgencyInfo this[int index] { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public void WriteData(string path)
        {
            Path = path;

            Tour(path);

        }
    }
}
