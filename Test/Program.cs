// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

List<Student> students = new List<Student>() 
{
    new() { StudentId = 1, StudentName = "John", Age = 18 },
    new() { StudentId = 2, StudentName = "Steve", Age = 21 },
    new() { StudentId = 3, StudentName = "Bill", Age = 25 },
    new() { StudentId = 4, StudentName = "Ram", Age = 20 },
};

const int AgeToRentCar = 24;
List<Student> studentsWhoCanRentCar = students
    .Where(s => s.Age >= AgeToRentCar)
    .OrderByDescending(s => s.StudentName)
    .ToList();

class Student
{
    public int StudentId { get; set; }

    public required string StudentName { get; set; }

    public int Age { get; set; }
}