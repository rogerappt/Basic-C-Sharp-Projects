using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
			using (var ctx = new SchoolContext())
			{
				var stud = new Student() { StudentName = "Bill" };

				ctx.Students.Add(stud);
				ctx.SaveChanges();

				Console.Write("Student saved successfully!");

			}
		}
    }
    public class SchoolContext : DbContext
    {
        public SchoolContext() : base()// passed dotnetfiddle specific connction string
        {
        }

        public DbSet<Student> Students { get; set; }        
    }

    public class Student
    {
        public int StudentID { get; set; }
        public string StudentName { get; set; }
    }

}

