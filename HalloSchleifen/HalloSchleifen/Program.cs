using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace HalloSchleifen
{
    class Program
    {
        static void Main(string[] args)
        {
            //Zählergesteuerte Schleife
            StreamWriter sw = null;
            try
            {
                sw = new StreamWriter("zahlen.txt");
                for (int i = 0; i < 100; i++)
                {
                    //Console.WriteLine(i);
                    sw.WriteLine(i);
                }

                
            }
            catch (Exception ex)
            {

            }
            finally
            {
                sw.Flush();
                sw.Close();
            }
            

            //kopfgesteuerte schleife
            StreamReader sr = null;
            int summe = 0;
            try
            {
                sr = new StreamReader("zahlen.txt");
                while (!sr.EndOfStream)
                {
                    string line = sr.ReadLine();

                    line += "abc";
                    Console.WriteLine(line);
                    summe += int.Parse(line);
                }
            }
            catch (Exception ex)
            {
                //Schreibe in Log
            }
            finally
            {
                
                sr.Close();
            }

            
            
            sr.Close();

            Console.WriteLine("Summe: " + summe);
            Console.WriteLine("Ende");
            Console.ReadLine();
        }
    }
}
