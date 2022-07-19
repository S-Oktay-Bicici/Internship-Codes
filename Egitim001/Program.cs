using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary001;

namespace Egitim001
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                var ao = new ClassLibrary001.ArkenomOps();
                var result = ao.CreateMusteriRecord(null, "bicici", "654849");

                if(result.hata)
                {
                    Console.WriteLine("ıslem başarılı");
                }
                else
                {
                    Console.WriteLine(result.hataDetayi);
                }
            }
            catch(Exception ex)
            {
                Concole.Writline("101: " + ex.Message); 
            }

            Console.ReadLine();
        }
    }
}
