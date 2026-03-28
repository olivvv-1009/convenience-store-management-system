using System;
using System.Collections.Generic;
using System.Linq;
using CSMS.Database;
using Microsoft.Data.SqlClient;
using convenience_store_management_system.Models;

namespace CSMS.Services
{
    public class EmployeeStats
    {
        public int total { get; set; }
        public int active { get; set; }
        public int admins { get; set; }
        public int staff { get; set; }
    }

    public class EmployeeService
    {
        private DbConnectionHelper db = new DbConnectionHelper();

        // ✅ LẤY DANH SÁCH NHÂN VIÊN
        public List<Employee> GetAllEmployees()
        {
            List<Employee> list = new List<Employee>();

            using (SqlConnection conn = db.GetConnection())
            {
                conn.Open();

                string query = "SELECT * FROM Employees";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        list.Add(new Employee
                        {
                            EmployeeId = Convert.ToInt32(reader["EmployeeId"]),
                            FullName = reader["FullName"].ToString(),
                            Email = reader["Email"]?.ToString(),
                            
                            Position = reader["Position"]?.ToString(),
                            HireDate = Convert.ToDateTime(reader["HireDate"]),
                            IsActive = Convert.ToBoolean(reader["IsActive"])
                        });
                    }
                }
            }

            return list;
        }

        // ✅ STATS
        public EmployeeStats GetEmployeeStats()
        {
            var list = GetAllEmployees();

            return new EmployeeStats
            {
                total = list.Count,
                active = list.Count(x => x.IsActive),
                admins = list.Count(x => x.Position == "Manager"),
                staff = list.Count(x => x.Position == "Staff")
            };
        }

        // ✅ UPDATE
        public void UpdateEmployee(Employee emp)
        {
            using (SqlConnection conn = db.GetConnection())
            {
                conn.Open();

                string query = @"
                    UPDATE Employees
                    SET FullName = @FullName,
                        Email = @Email,
                       
                        Position = @Position,
                        HireDate = @HireDate
                    WHERE EmployeeId = @Id";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@FullName", emp.FullName);
                    cmd.Parameters.AddWithValue("@Email", emp.Email);
                   
                    cmd.Parameters.AddWithValue("@Position", emp.Position);
                    cmd.Parameters.AddWithValue("@HireDate", emp.HireDate);
                    cmd.Parameters.AddWithValue("@Id", emp.EmployeeId);

                    cmd.ExecuteNonQuery();
                }
            }
        }

        // ✅ ADD
        public void AddEmployee(Employee emp)
        {
            using (SqlConnection conn = db.GetConnection())
            {
                conn.Open();

                string query = @"
                    INSERT INTO Employees (FullName, Email, Position, HireDate, IsActive)
                    VALUES (@FullName, @Email, @Position, @HireDate, 1)";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@FullName", emp.FullName);
                    cmd.Parameters.AddWithValue("@Email", emp.Email);
                    
                    cmd.Parameters.AddWithValue("@Position", emp.Position);
                    cmd.Parameters.AddWithValue("@HireDate", emp.HireDate);

                    cmd.ExecuteNonQuery();
                }
            }
        }

        public void ToggleActive(int id)
        {
            using (SqlConnection conn = db.GetConnection())
            {
                conn.Open();

                string query = @"
            UPDATE Employees
            SET IsActive = CASE WHEN IsActive = 1 THEN 0 ELSE 1 END
            WHERE EmployeeId = @Id";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@Id", id);
                    cmd.ExecuteNonQuery();
                }
            }
        }
    }
}