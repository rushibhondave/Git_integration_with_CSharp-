
using System;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;
namespace SerializationDemo
{
    [Serializable]
    public class Employee
    {
        public int id;
        public string name;
        public int age;
        static void Main(string[] args)
        {
            #region binaryserialization
            Employee e1 = new Employee();
            e1.id = 101; 
            e1.name = "Vivek";
            e1.age = 50;
            IFormatter f = new BinaryFormatter();
            string path, k;
            Stream str;
            int n = 1;
            string path1=@"D:\";

            XmlSerializer x = new XmlSerializer(e1.GetType());
            while (n != 0)
            {
                Console.WriteLine("\n1.create binary txt 2.create xml 3.read binary txt ");
                k = Console.ReadLine();
                n = Convert.ToInt32(k);
                switch (n)
                {
                    case 1:
                        //creating binary txt
                        Console.WriteLine("Enter the File Name...");
                        path = Console.ReadLine();
                        string fullpath = path1 + path;
                        str = new FileStream(fullpath, FileMode.Create, FileAccess.Write);
                        f.Serialize(str, e1);
                        str.Close();
                        break;

                    case 2:
                        //creating xml
                        Console.WriteLine("Enter the File Name...");
                        path = Console.ReadLine();
                        string fullpath11 = path1 + path;
                        str = new FileStream(fullpath11, FileMode.Create, FileAccess.Write);
                        x.Serialize(str, e1);
                        str.Close();
                        break;

                    case 3:
                        //reading binary by path
                        Console.WriteLine("Enter the File Name...");
                        path = Console.ReadLine();
                        string fullpath1 = path1 + path;
                        str = new FileStream(fullpath1, FileMode.Open, FileAccess.Read);
                        Employee s2 = (Employee)f.Deserialize(str);
                        Console.WriteLine("Roll Number: {0}", s2.id);   
                        Console.WriteLine("Name: {0}", s2.name);
                        Console.WriteLine("Marks: {0}", s2.age);
                        break;
                }
            }
            // Console.ReadLine();
        }
        #endregion
        #region XMLserialization
        #endregion
        // ////Console.WriteLine("Marks: {0}", s2.marks);

    }
}

