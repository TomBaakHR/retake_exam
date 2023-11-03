using Microsoft.EntityFrameworkCore;

class Program
{
    static public void Main() {
        //first line of code is there to solve any issue with date-time format. 
        System.Threading.Thread.CurrentThread.CurrentCulture = System.Globalization.CultureInfo.GetCultureInfo("EN-US");
       
        var db = new ExamContext();
        Seed.SeedData(db); // Run it at most and at least once only and then comment it.

        /*Create a file with your studentnumber and hr prefix like hr098765.cs/ 
         * create a class named same hr098765 and 
         * implement all public static methods. 
         * calls them from main.
         * hint given below
         */

        //hr0987654.Q1(db, "Johan");
        //hr0987654.Q2(db, 1);
        //hr0987654.Q3(db);
        //hr0987654.Q4(db, 1000);
        //hr0987654.Q5(db);
        //hr0987654.Q6(db);
        //hr0987654.Q7(db, "NL", 10);
        //hr0987654.Q8(db, 100);
    }
}

//class hr098764
//{
//    public static void Q1(ExamContext db, string Name) { }
//    public static void Q2(ExamContext db, int ProductID) { }
//    public static void Q3(ExamContext db) { }
//    public static void Q4(ExamContext db, int OrderID) { }
//    public static void Q5(ExamContext db) { }
//    public static void Q6(ExamContext db) { }
//    public static void Q7(ExamContext db, string Country, decimal fraction){}
//    public static void Q8(ExamContext db, int OrderID) { }
//}