
class Solution
{
    
    public static void Q1(ExamContext db, string Name)
    {
        var customers = db.Customers.Where(c => c.FirstName == "John" || c.LastName == "John");

        foreach (var item in customers)
        {
            Console.WriteLine($"ID: {item.ID}, Firstname: {item.FirstName}, Lastname: {item.LastName}");
        }
    }

    public static void Q2(ExamContext db, int ProductID)
    {
       
    }

    public static void Q3(ExamContext db)
    {
        
    }

    public static void Q4(ExamContext db, int OrderID)
    {
       
    }

    public static void Q5(ExamContext db)
    {
 
    }

    public static void Q6(ExamContext db)
    {

    }
    public static void Q7(ExamContext db, string Country, decimal fraction)
    {


    }
    public static void Q8(ExamContext db, int OrderID)
    {
    
    }

}