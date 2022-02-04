using System;


namespace ClassDemoTemplate
{
    class Program
    {
        static void Main(string[] args)
        {
            //IAbstractADT adt = new ListADT();
            IAbstractADT adt = new SetADT();

            adt.Add("Peter");
            adt.Add("Anders");
            adt.Add("Jens Peter");
            adt.Add("Michael");
            adt.Add("Michael");
            
            Console.WriteLine(adt);
        }
    }
}
