using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace demo01
{
    class Program
    {
        static void Main(string[] args)
        {
            StreamReader sr = null;
            try
            {
                sr = new StreamReader(@"D:\data.tx");
                Console.WriteLine(sr.ReadToEnd());
                sr.Close();
            }
            catch (FileNotFoundException ex)
            {

                Console.WriteLine(ex.Message);
            }

            finally
            {
                if(sr != null)
                    sr.Close();
            }
                
           
            
            
        }
    }
}
