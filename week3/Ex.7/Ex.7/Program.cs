using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        // สร้างรายการพนักงาน
        List<Employee> employees = new List<Employee>();
        bool exit = false;

        // วนลูปเมนูหลักเพื่อรับอินพุตจากผู้ใช้
        while (!exit)
        {
            Console.WriteLine("Employee Management System");
            Console.WriteLine("1. Add a new employee");
            Console.WriteLine("2. Remove an existing employee");
            Console.WriteLine("3. Update employee details");
            Console.WriteLine("4. Display all employee records");
            Console.WriteLine("5. Exit");
            Console.Write("Select an option: ");
            string option = Console.ReadLine();

            // เลือกฟังก์ชันตามตัวเลือกที่เลือก
            switch (option)
            {
                case "1":
                    AddEmployee(employees); // เรียกฟังก์ชันเพิ่มพนักงาน
                    break;
                case "2":
                    RemoveEmployee(employees); // เรียกฟังก์ชันลบพนักงาน
                    break;
                case "3":
                    UpdateEmployee(employees); // เรียกฟังก์ชันอัปเดตรายละเอียดพนักงาน
                    break;
                case "4":
                    DisplayEmployees(employees); // เรียกฟังก์ชันแสดงข้อมูลพนักงานทั้งหมด
                    break;
                case "5":
                    exit = true; // ออกจากลูป
                    break;
                default:
                    Console.WriteLine("Invalid option. Please try again."); // กรณีที่ผู้ใช้ป้อนตัวเลือกที่ไม่ถูกต้อง
                    break;
            }
        }
    }

    // ฟังก์ชันเพิ่มพนักงาน
    static void AddEmployee(List<Employee> employees)
    {
        Console.Write("Enter employee ID: ");
        int id = int.Parse(Console.ReadLine());

        Console.Write("Enter employee name: ");
        string name = Console.ReadLine();

        Console.Write("Enter employee age: ");
        int age = int.Parse(Console.ReadLine());

        Console.Write("Enter employee department: ");
        string department = Console.ReadLine();

        // เพิ่มพนักงานใหม่ไปยังรายการพนักงาน
        employees.Add(new Employee(id, name, age, department));
        Console.WriteLine("Employee added successfully.");
    }

    // ฟังก์ชันลบพนักงาน
    static void RemoveEmployee(List<Employee> employees)
    {
        Console.Write("Enter employee ID to remove: ");
        int id = int.Parse(Console.ReadLine());

        // ค้นหาพนักงานโดยใช้ ID
        Employee employee = employees.Find(e => e.ID == id);
        if (employee != null)
        {
            employees.Remove(employee); // ลบพนักงานหากพบ
            Console.WriteLine("Employee removed successfully.");
        }
        else
        {
            Console.WriteLine("Employee not found."); // กรณีที่ไม่พบพนักงาน
        }
    }

    // ฟังก์ชันอัปเดตรายละเอียดพนักงาน
    static void UpdateEmployee(List<Employee> employees)
    {
        Console.Write("Enter employee ID to update: ");
        int id = int.Parse(Console.ReadLine());

        // ค้นหาพนักงานโดยใช้ ID
        Employee employee = employees.Find(e => e.ID == id);
        if (employee != null)
        {
            Console.Write("Enter new employee name: ");
            employee.Name = Console.ReadLine();

            Console.Write("Enter new employee age: ");
            employee.Age = int.Parse(Console.ReadLine());

            Console.Write("Enter new employee department: ");
            employee.Department = Console.ReadLine();

            Console.WriteLine("Employee details updated successfully.");
        }
        else
        {
            Console.WriteLine("Employee not found."); // กรณีที่ไม่พบพนักงาน
        }
    }

    // ฟังก์ชันแสดงข้อมูลพนักงานทั้งหมด
    static void DisplayEmployees(List<Employee> employees)
    {
        if (employees.Count > 0)
        {
            Console.WriteLine("Employee Records:");
            foreach (Employee employee in employees)
            {
                Console.WriteLine($"ID: {employee.ID}, Name: {employee.Name}, Age: {employee.Age}, Department: {employee.Department}");
            }
        }
        else
        {
            Console.WriteLine("No employee records found."); // กรณีที่ไม่มีข้อมูลพนักงาน
        }
    }
}

// คลาส Employee สำหรับเก็บข้อมูลพนักงาน
class Employee
{
    public int ID { get; set; }
    public string Name { get; set; }
    public int Age { get; set; }
    public string Department { get; set; }

    // คอนสตรัคเตอร์สำหรับสร้างวัตถุ Employee
    public Employee(int id, string name, int age, string department)
    {
        ID = id;
        Name = name;
        Age = age;
        Department = department;
    }
}
