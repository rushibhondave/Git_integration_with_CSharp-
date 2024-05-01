using System;
using System.Collections;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace SampleApplication
{
    [Serializable]
    public class Employee
    {
    
       
        private string ID;
        private string name;

        static void Main(string[] args)
        {
            string path = @"D:\\Java_full_stack\\Full-Stack\\Back_End\\C#\\.Assignment";
            Employee emp = new Employee();
            emp.ID =" 1";
            emp.name = "Test";

        }
    }


 }

