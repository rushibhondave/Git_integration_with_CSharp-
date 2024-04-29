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
    public class Student
    {
        public int rno;
        public string name;
        public double marks;
        static void Main(string[] args)
        {
            #region binaryserialization
            Student s1 = new Student();
            s1.rno = 1;
            s1.name = "John Smith";
            s1.marks = 87.5;
            IFormatter f = new BinaryFormatter();
            string path, k;
            Stream str;
            int n = 1;
            XmlSerializer x = new XmlSerializer(s1.GetType());
            while (n != 0)
            {
                Console.WriteLine("\n1.create binary txt 2.read binary txt 3.create xml ");
                k = Console.ReadLine();
                n = Convert.ToInt32(k);
                switch (n)
                {
                    case 1:
                        //creating binary txt
                        path = Console.ReadLine();
                        str = new FileStream(path, FileMode.Create, FileAccess.Write);
                        f.Serialize(str, s1);
                        str.Close();
                        break;
                    case 2:
                        //reading binary by path
                        path = Console.ReadLine();
                        str = new FileStream(path, FileMode.Open, FileAccess.Read);
                        Student s2 = (Student)f.Deserialize(str);
                        Console.WriteLine("Roll Number: {0}", s2.rno);
                        Console.WriteLine("Name: {0}", s2.name);
                        Console.WriteLine("Marks: {0}", s2.marks);
                        break;
                    case 3:
                        //creating xml
                        path = Console.ReadLine();
                        str = new FileStream(path, FileMode.Create, FileAccess.Write);
                        x.Serialize(str, s1);
                        str.Close();
                        break;

                    case 4:
                        path = Console.ReadLine();
                        //reading xml
                        //System.Xml.Serialization.XmlSerializer x = new System.Xml.Serialization.XmlSerializer(s1.GetType());
                        str = new FileStream(path, FileMode.Open, FileAccess.Read);
                        XmlReader reader = XmlReader.Create(path);

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

