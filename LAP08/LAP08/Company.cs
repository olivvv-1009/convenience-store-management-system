using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;

namespace LAP08
{
    public class Company
    {
        public string Name { get; set; }
        public string Address { get; set; }
        public List<Employee> Employees { get; set; }

        public Company()
        {
            Employees = new List<Employee>();
        }

        public Company(string name, string address) : this()
        {
            Name = name;
            Address = address;
        }

        public void AddEmployee(Employee e)
        {
            Employees.Add(e);
        }

        // In bảng lương
        public void PrintSalaryTable()
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            Console.WriteLine("\n================ BẢNG LƯƠNG NHÂN VIÊN ================\n");

            // Header
            Console.WriteLine("{0,-5} {1,-20} {2,-10} {3,-15} {4,-15} {5,-15}",
                "STT", "HỌ TÊN", "TUỔI", "HỆ SỐ LƯƠNG", "LƯƠNG", "NGÀY VÀO");

            Console.WriteLine(new string('-', 85));

            int stt = 1;
            double total = 0;

            foreach (var e in Employees)
            {
                Console.WriteLine("{0,-5} {1,-20} {2,-10} {3,-15:F2} {4,-15:N0} {5,-15}",
                    stt++,
                    e.Name,
                    e.Age,
                    e.GetCurrentCoef(),
                    e.CalculateSalary(),
                    e.ParticipationDate.ToShortDateString());

                total += e.CalculateSalary();
            }

            Console.WriteLine(new string('-', 85));
            Console.WriteLine($"TỔNG LƯƠNG: {total:N0} VND\n");
        }

        // Serialization
        public void SaveToFile(string filePath)
        {
            string json = JsonSerializer.Serialize(this, new JsonSerializerOptions
            {
                WriteIndented = true
            });
            File.WriteAllText(filePath, json);
        }

        // Deserialization
        public static Company LoadFromFile(string filePath)
        {
            string json = File.ReadAllText(filePath);
            return JsonSerializer.Deserialize<Company>(json);
        }
    }
}
