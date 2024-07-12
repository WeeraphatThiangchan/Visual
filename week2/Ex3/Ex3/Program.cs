using System;
using System.Globalization;

class Program
{
    static void Main()
    {
        // ข้อมูลตัวอย่าง
        DateTime inputDate = new DateTime(2024, 7, 5); // เปลี่ยนเป็นวันที่ที่ต้องการตรวจสอบ
        bool isHoliday = IsHoliday(inputDate);

        string dayOfWeekThai = inputDate.ToString("dddd", new CultureInfo("th-TH"));
        string formattedDate = inputDate.ToString("dd/MM/yyyy", new CultureInfo("th-TH"));

        Console.WriteLine($"วัน{dayOfWeekThai}ที่ {formattedDate} เป็นวันหยุดหรือไม่: {isHoliday}");
    }

    static bool IsHoliday(DateTime date)
    {
        // ตรวจสอบว่าวันที่เป็นวันเสาร์หรืออาทิตย์
        if (date.DayOfWeek == DayOfWeek.Saturday || date.DayOfWeek == DayOfWeek.Sunday)
        {
            return true;
        }

        // ตรวจสอบว่าวันที่เป็นวันหยุดนักขัตฤกษ์หรือไม่ (ตัวอย่าง)
        DateTime[] publicHolidays = {
            new DateTime(date.Year, 1, 1),   // วันปีใหม่
            new DateTime(2024, 3, 6), // วันมาฆบูชา
            new DateTime(2024, 4, 6), // วันจักรี
            new DateTime(2024, 4, 13), // วันสงกรานต์
            new DateTime(2024, 4, 14), // วันสงกรานต์
            new DateTime(2024, 4, 15), // วันสงกรานต์
            new DateTime(2024, 4, 16), // วันสงกรานต์
            new DateTime(2024, 5, 1), // วันแรงงาน
            new DateTime(2024, 5, 6), // วันฉัตรมงคล
            new DateTime(2024, 5, 13), // วันพืชมงคล
            new DateTime(2024, 5, 29), // วันวิสาขบูชา
            new DateTime(2024, 7, 22), // วันอาสาฬหบูชา
            new DateTime(2024, 7, 23), // วันเข้าพรรษา
            new DateTime(2024, 8, 12), // วันแม่แห่งชาติ
            new DateTime(2024, 10, 13), // วันคล้ายวันสวรรคต ร.9
            new DateTime(2024, 10, 14), // วันหยุดชดเชยวันคล้ายวันสวรรคต ร.9
            new DateTime(2024, 10, 23), // วันปิยมหาราช
            new DateTime(2024, 12, 5), // วันพ่อแห่งชาติ
            new DateTime(2024, 12, 10), // วันรัฐธรรมนูญ
            new DateTime(date.Year, 12, 31), // วันสิ้นปี
        };

        foreach (var holiday in publicHolidays)
        {
            if (date.Date == holiday.Date)
            {
                return true;
            }
        }

        // ตรวจสอบว่าวันที่เป็นวันหยุดพิเศษที่บริษัทประกาศหรือไม่ (ตัวอย่าง)
        DateTime[] companyHolidays = {
            new DateTime(date.Year, 7, 5),   // วันหยุดพิเศษที่บริษัทประกาศ
            // เพิ่มวันหยุดพิเศษอื่นๆ ตามต้องการ
        };

        foreach (var holiday in companyHolidays)
        {
            if (date.Date == holiday.Date)
            {
                return true;
            }
        }

        // ถ้าไม่ใช่วันหยุดใดๆ
        return false;
    }
}
