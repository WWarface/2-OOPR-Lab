using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_laba_oop
{

    class TouristTravelInfo//////можно використати voucher но я вже запутався шо вообще приісходе 
    {
        public string From { get; set; }

        public int Duration { get; set; }
        
        public string ToCountry { get; set; }

        public int Price { get; set; }
        public int Day { get; set; }
        public int Month { get; set; }


        public static string Path { get; set; }

        public void WriteData(string path)
        {
            Path = path;
            using (StreamWriter writer = new StreamWriter(path, false))
            {
                writer.WriteLine(this.From);
                writer.WriteLine(this.ToCountry);
                writer.WriteLine(this.Price);
                writer.WriteLine(this.Day);
                writer.WriteLine(this.Month);
                writer.WriteLine(this.Duration);
            }
        }

        public void ReadData()
        {
            using (StreamReader reader = new StreamReader(Path))
            {
                this.From = reader.ReadLine();
                this.ToCountry = reader.ReadLine();
                this.Price = Int16.Parse(reader.ReadLine());
                this.Day = Int16.Parse(reader.ReadLine());
                this.Month = Int16.Parse(reader.ReadLine());
                this.Duration = Int16.Parse(reader.ReadLine());
            }
        }
    }
}
