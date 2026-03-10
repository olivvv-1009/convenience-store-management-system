using System;
using LAP08;

class Program
{
    static void Main(string[] args)
    {
        Company company = new Company("ABC Company", "HCM City");

        company.AddEmployee(new Employee("An", 25, "E01", 2.3, new DateTime(2018, 5, 1), "Bachelor"));
        company.AddEmployee(new Employee("Binh", 28, "E02", 2.6, new DateTime(2016, 3, 10), "Master"));
        company.AddEmployee(new Employee("Cuong", 30, "E03", 3.0, new DateTime(2015, 7, 15), "PhD"));
        company.AddEmployee(new Employee("Dung", 26, "E04", 2.1, new DateTime(2020, 1, 20), "Bachelor"));
        company.AddEmployee(new Employee("Em", 24, "E05", 2.0, new DateTime(2022, 9, 5), "College"));

        // In bảng lương
        company.PrintSalaryTable();

        // Lưu file
        string path = "company.dat";
        company.SaveToFile(path);
        Console.WriteLine("\nSaved to file successfully!");

        // Đọc file
        Company loadedCompany = Company.LoadFromFile(path);
        Console.WriteLine("\n=== DATA AFTER DESERIALIZATION ===");
        loadedCompany.PrintSalaryTable();
    }
}