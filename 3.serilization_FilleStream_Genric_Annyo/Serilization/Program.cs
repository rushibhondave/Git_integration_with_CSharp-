using System.Runtime.Serialization.Formatters.Binary;

namespace Serilization
{



    [Serializable]
    class Emp
    {
        int id;
        string name;

        public Emp(int id ,string name)
        {
            this.id = id;
            this.name = name;   
        }



    }
    internal class Program
    {
        static void Main(string[] args)
        {
            string path = @"D:\Java_full_stack\Full-Stack\Back_End\C#\3.serilization_FilleStream_Genric_Annyo\sample.txt";
            using (FileStream fileStream = new FileStream(path, FileMode.OpenOrCreate))
            {
                Emp emp1 = new Emp(1,"Rushi");
                BinaryFormatter bf = new BinaryFormatter();
                bf.Serialize(fileStream, emp1);
               
            }

            using (FileStream fileStream = new FileStream(path, FileMode.OpenOrCreate))
            {
            
                BinaryFormatter bf = new BinaryFormatter();
                Emp emp1 = (Emp)bf.Serialize(fileStream, emp1);

            }




        }
    }
}
