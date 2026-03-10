using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAP08
{
    public class Employee : Human
    {
        public string Id { get; set; }
        public double CoefSalary { get; set; }
        public DateTime ParticipationDate { get; set; }
        public string EduLevel { get; set; }

        private const double BASE_SALARY = 1800000; // lương cơ bản

        public Employee() { }

        public Employee(string name, int age, string id, double coefSalary,
                        DateTime participationDate, string eduLevel)
            : base(name, age)
        {
            Id = id;
            CoefSalary = coefSalary;
            ParticipationDate = participationDate;
            EduLevel = eduLevel;
        }

        // Tính số năm làm việc
        public int GetWorkingYears()
        {
            return DateTime.Now.Year - ParticipationDate.Year;
        }

        // Tính hệ số lương hiện tại
        public double GetCurrentCoef()
        {
            int raiseTimes = GetWorkingYears() / 3;
            return CoefSalary + raiseTimes * 0.3;
        }

        // Tính lương
        public double CalculateSalary()
        {
            return GetCurrentCoef() * BASE_SALARY;
        }

        public override void Print()
        {
            base.Print();
            Console.WriteLine($"ID: {Id}");
            Console.WriteLine($"Education: {EduLevel}");
            Console.WriteLine($"Participation Date: {ParticipationDate.ToShortDateString()}");
            Console.WriteLine($"Current Coef Salary: {GetCurrentCoef():0.00}");
            Console.WriteLine($"Salary: {CalculateSalary():N0} VND");
            Console.WriteLine("---------------------------");
        }
    }
}
