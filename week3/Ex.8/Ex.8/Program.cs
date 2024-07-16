using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        // สร้างรายการสินค้าคงคลัง
        List<Product> inventory = new List<Product>();
        bool exit = false;

        // วนลูปเมนูหลักเพื่อรับอินพุตจากผู้ใช้
        while (!exit)
        {
            Console.WriteLine("Inventory Management System");
            Console.WriteLine("1. Add a new product");
            Console.WriteLine("2. Remove an existing product");
            Console.WriteLine("3. Search for a product by name");
            Console.WriteLine("4. Display all products in the inventory");
            Console.WriteLine("5. Exit");
            Console.Write("Select an option: ");
            string option = Console.ReadLine();

            // เลือกฟังก์ชันตามตัวเลือกที่เลือก
            switch (option)
            {
                case "1":
                    AddProduct(inventory); // เรียกฟังก์ชันเพิ่มสินค้าใหม่
                    break;
                case "2":
                    RemoveProduct(inventory); // เรียกฟังก์ชันลบสินค้า
                    break;
                case "3":
                    SearchProduct(inventory); // เรียกฟังก์ชันค้นหาสินค้าโดยใช้ชื่อ
                    break;
                case "4":
                    DisplayProducts(inventory); // เรียกฟังก์ชันแสดงข้อมูลสินค้าทั้งหมด
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

    // ฟังก์ชันเพิ่มสินค้าใหม่
    static void AddProduct(List<Product> inventory)
    {
        Console.Write("Enter product ID: ");
        int id = int.Parse(Console.ReadLine());

        Console.Write("Enter product name: ");
        string name = Console.ReadLine();

        Console.Write("Enter product quantity: ");
        int quantity = int.Parse(Console.ReadLine());

        Console.Write("Enter product price: ");
        double price = double.Parse(Console.ReadLine());

        // เพิ่มสินค้าตัวใหม่ไปยังรายการสินค้าคงคลัง
        inventory.Add(new Product(id, name, quantity, price));
        Console.WriteLine("Product added successfully.");
    }

    // ฟังก์ชันลบสินค้า
    static void RemoveProduct(List<Product> inventory)
    {
        Console.Write("Enter product ID to remove: ");
        int id = int.Parse(Console.ReadLine());

        // ค้นหาสินค้าโดยใช้ ID
        Product product = inventory.Find(p => p.ID == id);
        if (product != null)
        {
            inventory.Remove(product); // ลบสินค้าหากพบ
            Console.WriteLine("Product removed successfully.");
        }
        else
        {
            Console.WriteLine("Product not found."); // กรณีที่ไม่พบสินค้า
        }
    }

    // ฟังก์ชันค้นหาสินค้าโดยใช้ชื่อ
    static void SearchProduct(List<Product> inventory)
    {
        Console.Write("Enter product name to search: ");
        string name = Console.ReadLine();

        // ค้นหาสินค้าโดยใช้ชื่อ
        Product product = inventory.Find(p => p.Name.Equals(name, StringComparison.OrdinalIgnoreCase));
        if (product != null)
        {
            Console.WriteLine($"ID: {product.ID}, Name: {product.Name}, Quantity: {product.Quantity}, Price: {product.Price}");
        }
        else
        {
            Console.WriteLine("Product not found."); // กรณีที่ไม่พบสินค้า
        }
    }

    // ฟังก์ชันแสดงข้อมูลสินค้าทั้งหมดในคลัง
    static void DisplayProducts(List<Product> inventory)
    {
        if (inventory.Count > 0)
        {
            Console.WriteLine("Product Records:");
            foreach (Product product in inventory)
            {
                Console.WriteLine($"ID: {product.ID}, Name: {product.Name}, Quantity: {product.Quantity}, Price: {product.Price}");
            }
        }
        else
        {
            Console.WriteLine("No products found in the inventory."); // กรณีที่ไม่มีข้อมูลสินค้าในคลัง
        }
    }
}

// คลาส Product สำหรับเก็บข้อมูลสินค้า
class Product
{
    public int ID { get; set; }
    public string Name { get; set; }
    public int Quantity { get; set; }
    public double Price { get; set; }

    // คอนสตรัคเตอร์สำหรับสร้างวัตถุ Product
    public Product(int id, string name, int quantity, double price)
    {
        ID = id;
        Name = name;
        Quantity = quantity;
        Price = price;
    }
}
