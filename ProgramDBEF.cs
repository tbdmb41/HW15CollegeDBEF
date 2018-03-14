using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using System.ComponentModel.DataAnnotations;
using static System.Console;
namespace CollegeDBEF
{
public class CollegeBEEF : DbContext
{
public DbSet<Score> Scores { get; set; }
public DbSet<Class> Classes { get; set; }
public DbSet<Student> Students { get; set; }
}
public class Student
{
[Key] public int ID { get; set; }
public string FName { get; set; }
public string LName { get; set; }
public string Address { get; set; }
public string City { get; set; }
public string Phone { get; set; }
public virtual List<Score> Grades { get; set; }
}
public class Class
{
public int ID { get; set; }
[Key] public string Title { get; set; }
public int Number { get; set; }
public string Dept { get; set; }
}
}
public class Score
{
[Key] public int ID { get; set; }
public string Type { get; set; }
public DateTime DateDue { get; set; }
public int PointsEarned { get; set; }
public int PointsPossible { get; set; }
public virtual Class Class_obj { get; set; }
}

class Program
{
    static void Main(string[] args)
    {
        using (var db = new CollegeBEEF())
        {
            var class1 = new Class
            {
                var student1 = new Student

                ID = "654",
                FName = "Carter",
                LName = "Beauford",
                Address = "8600 Pickle Thrower Way",
                City = "Ginger",
                State = "FL",
                Phone = 6548974125,
                Grades = new List<Score>()
            };

            db.Students.Add(student1);
        }

        Score student1Score1 = new Score
        {
            Class_obj = class1,
            Type = "Hollowed Point Quiz 1",
            DateDue = DateTime.Parse("11-10-18"),
            PointsEarned = 8,
            PointsPossible = 10,
        };
        student1.Grades.Add(student1Score1);
        {


            Score student1Score2 = new Score
            {
                Class_obj = class2,
                Type = "Firearms 101 Quiz 1",
                DateDue = DateTime.Parse("06-1-18"),
                PointsEarned = 13,
                PointsPossible = 15,
            };


            student1.Grades.Add(student1Score2);

            Score student1Score3 = new Score
            {
                Class_obj = class3,
                Type = "S&W 101",
                DateDue = DateTime.Parse("03-02-18"),
                PointsEarned = 63,
                PointsPossible = 75,
            };

            student1.Grades.Add(student1Score3);

            Score student1Score3 = new Score
            {
                Class_obj = class4,
                Type = "Running",
                DateDue = DateTime.Parse("03-02-18"),
                PointsEarned = 63,
                PointsPossible = 75,
            };





            {
                db.Students.Add(student2);
                {

                    var student2 = new Student
                    {
                        ID = "940",
                        FName = "The",
                        LName = "Dude",
                        Address = "32 The Dude Abides Lane",
                        City = "Dudeville",
                        Phone = 2158447777,
                        Grades = new List<Score>()
                    };


                    Score student2Score1 = new Score
                    {
                        Class_obj = class2,
                        Type = "Installing A Windmill",
                        DateDue = DateTime.Parse("11-06-18"),
                        PointsEarned = 8,
                        PointsPossible = 10,
                    };

                    student2.Grades.Add(student2Score2);

                    Score student2Score2 = new Score
                    {
                        Class_obj = class3,
                        Type = "Gascan Fireworks",
                        DateDue = DateTime.Parse("04-23-18"),
                        PointsEarned = 12,
                        PointsPossible = 15,
                    };

                    Student2.Grades.Add(student2Score3);

                    Score student2Score3 = new Score
                    {
                        Class_obj = class1,
                        Type = "This is Cleveland Codes",
                        DateDue = DateTime.Parse("11-06-18"),
                        PointsEarned = 0,
                        PointsPossible = 10,
                    };
                    db.Students.Add(student3);


                    var student3 = new Student
                    {
                        ID = "940",
                        FName = "The",
                        LName = "Dude",
                        Address = "32 The Dude Abides Lane",
                        City = "Dudeville",
                        Phone = 2158447777,
                        Grades = new List<Score>()
                    };
                    db.Students.Add(student3);


                    Score student3Score1 = new Score
                    {
                        Class_obj = class3,
                        Type = "Crowbar Making Quiz",
                        DateDue = DateTime.Parse("3-17-18"),
                        PointsEarned = 10,
                        PointsPossible = 10,
                    };


                    Score student3Score2 = new Score
                    {
                        Class_obj = class2,
                        Type = "Knife Throwing Test",
                        DateDue = DateTime.Parse("1-7-18"),
                        PointsEarned = 8,
                        PointsPossible = 10,
                    };


                    Score student3Score3 = new Score
                    {
                        Class_obj = class1,
                        Type = "Fighting a Tornado",
                        DateDue = DateTime.Parse("9-18-18"),
                        PointsEarned = 0,
                        PointsPossible = 10,
                    };



                    var student3 = new Student
                    {
                        ID = "876",
                        FName = "Bennie",
                        LName = "Jetts",
                        Address = "25 Old Time Way",
                        City = "Charlottesville",
                        Phone = 2254789654,
                        Grades = new List<Score>()
                    };

                    db.Students.Add(student3);

                    Score student3Score1 = new Score
                    {
                        Class_obj = class1,
                        Type = "Escaping a Raccoon",
                        DateDue = DateTime.Parse("08-12-18"),
                        PointsEarned = 0,
                        PointsPossible = 15,
                    };
                    student3.Grades.Add(student3Score1);

                    Score student3Score2 = new Score
                    {
                        Class_obj = class3,
                        Type = "Jogging",
                        DateDue = DateTime.Parse("12-23-18"),
                        PointsEarned = 99,
                        PointsPossible = 100,
                    };
                    student3.Grades.Add(student3Score2);

                    Score student3Score3 = new Score
                    {
                        Class_obj = class3,
                        Type = "Midterm",
                        Description = "Eating Bagels",
                        DateDue = DateTime.Parse("03-18-18"),
                        PointsEarned = 25,
                        PointsPossible = 25,
                    };
                    student3.Grades.Add(student3Score3);

                    db.SaveChanges();

                    var queryStudentScores =
                        from student in db.Students
                        select student;


                    WriteLine();
                    WriteLine("All done.");
                    WriteLine("Press any key to Exit");
                    ReadKey();
                }
            }
        }
    }
}
        