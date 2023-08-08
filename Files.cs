using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpTasks
{
    internal class Trainees
    {
        public void getTrainee()
        {

           FileInfo fileInfo = new FileInfo(@"D:\Tasks\Trainees.txt");
            FileStream fileStream = fileInfo.Open(FileMode.OpenOrCreate, FileAccess.ReadWrite);
            StreamWriter streamWriter = new StreamWriter(fileStream);
            try
            {

                streamWriter.WriteLine("Hello srikanth");
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            finally {

                streamWriter.Close();
                fileStream.Close(); }

        }
    }

    internal class Files
    {

        static void Main(string[] args)
        {
            Trainees trainees = new Trainees();
            trainees.getTrainee();
            Console.ReadKey();
        }
    }
}
