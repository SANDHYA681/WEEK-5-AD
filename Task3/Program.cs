using System;
using Task3;

class Program
{
    static void Main(string[] args)
    {
        
        Printer p = new Printer();
        p.Print("Hello Sandhya");
        p.Print(123);
        p.Print("Have a good day" );

        Console.WriteLine();  

        
        NepaliTeacher np = new NepaliTeacher();
        np.Name = "Sandhya";
        np.Teaching();      
        np.SalaryInfo();    

        Console.WriteLine();

        EnglishTeacher en = new EnglishTeacher();
        en.Name = "Sndy";
        en.Teaching();      
        en.SalaryInfo();   
    }
}
