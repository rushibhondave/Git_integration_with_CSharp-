

namespace delagate
{
    public delegate void del();
    internal class dele
    {
        static void Main(string[] args)
        {
            
        }

    }
}
interface Myrushi
{
    void pdfviewer();
    void Excelviewer();

    void Documentviewer();

}

class rushi : Myrushi
{
    void Myrushi.Documentviewer()
    {
        Console.WriteLine("Documentviewer");
    }

    void Myrushi.Excelviewer()
    {
        Console.WriteLine("Excelviewer");
    }

    void Myrushi.pdfviewer()
    {
        Console.WriteLine("pdfviewer");
    }
}