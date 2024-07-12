using System;

class Program
{
    static void Main()
    {
        int height;
        
        // วนลูปจนกว่าจะมีการป้อนความสูงที่ถูกต้อง
        while (true)
        {
            Console.Write("กรุณาป้อนความสูงของเลข 8 (ต้องเป็นเลขคี่และมากกว่า 5): ");
            if (int.TryParse(Console.ReadLine(), out height) && height > 5 && height % 2 != 0)
            {
                break;
            }
            else
            {
                Console.WriteLine("ข้อมูลไม่ถูกต้อง กรุณาป้อนเลขคี่ที่มากกว่า 5.");
            }
        }

        DrawNumberEight(height);
    }

    static void DrawNumberEight(int height)
    {
        int mid = height / 2;

        for (int i = 0; i < height; i++)
        {
            if (i == 0 || i == mid || i == height - 1)
            {
                Console.WriteLine(new string('*', height));
            }
            else
            {
                Console.Write('*');
                for (int j = 1; j < height - 1; j++)
                {
                    Console.Write(' ');
                }
                Console.WriteLine('*');
            }
        }
    }
}
