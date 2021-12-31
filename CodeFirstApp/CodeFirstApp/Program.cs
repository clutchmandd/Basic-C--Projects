using System;

namespace CodeFirstApp
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var ctx = new SchoolContext())
            {
                var student = new Student() { StudentName = "David Dixon" };

                ctx.Students.Add(student);
                ctx.SaveChanges();
            }
        }
    }
}
