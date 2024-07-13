using System;
using System.Data;

class Program
{
    static void Main()
    {
        // รับสมการคณิตศาสตร์เป็นสตริงจากผู้ใช้
        Console.Write("Enter a mathematical expression:");
        string expression = Console.ReadLine();
        Console.WriteLine();
        
        try
        {
            // คำนวณผลลัพธ์ของสมการ
            double result = EvaluateExpression(expression);
            Console.WriteLine("The result is: " + result);
        }
        catch (Exception ex)
        {
            // แสดงข้อความเมื่อเกิดข้อผิดพลาด
            Console.WriteLine("Invalid expression. Please enter a valid mathematical expression.");
        }
    }

    static double EvaluateExpression(string expression)
    {
        // ใช้ DataTable.Compute เพื่อคำนวณผลลัพธ์ของสมการ
        DataTable table = new DataTable();
        table.Columns.Add("expression", typeof(string), expression);
        DataRow row = table.NewRow();
        table.Rows.Add(row);
        double result = double.Parse((string)row["expression"]);
        return result;
    }
}
