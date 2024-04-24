namespace _3_Assignment_File_Logger
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Logger logger = new Logger(); // Logger object created
            string fullpath = @"D:\Rushi.txt";
            FileStream f = new FileStream(fullpath, FileMode.OpenOrCreate | FileMode.Append,
                                            FileAccess.Write);

            StreamWriter write = new StreamWriter(f);   //Object created
            Console.WriteLine("Please Enter the Text Here: ");
            string txt = Console.ReadLine();
            string txtLog = logger.log("Text saved successfulyy");
            write.WriteLine(txt);

            write.WriteLine(txtLog);
            write.Close();
            f.Close();
            Console.WriteLine("Success");
        }
    }
    public class Logger
    {
        public Logger()  //Logger Constructor
        {
            Console.WriteLine("The Logger Object Created");

        }
        public string log(string msg)
        {
            string logmsg = " Logged msg " + msg + " created at " + DateTime.Now.ToString();
            return logmsg;
        }
    }
}