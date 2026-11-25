using Study;

var students = new List<Student>();


students.Add(new Student { ID = 1, Name = "Vu Nhat Minh", Age = 20 });
students.Add(new Student { ID = 2, Name = "Nguyen Thi Anh Thu", Age = 16 });
students.Add(new Student { ID = 3, Name = "Tran Minh Dang", Age = 20 });
students.Add(new Student { ID = 4, Name = "Nguyen Van A", Age = 18 });
students.Add(new Student { ID = 5, Name = "A Thi B", Age = 15 });


//in toan bo danh sach hoc sinh
Console.WriteLine("Danh sach hoc sinh:");
foreach (var student in students)
{
    Console.WriteLine($"ID: {student.ID}, Name: {student.Name}, Age: {student.Age}");
}
Console.WriteLine("==================================================\n");

//tim va in ra danh sach cac hoc sinh co tuoi tu 15 den 18
List<Student> youngStudents = students.Where(s => s.Age >= 15 && s.Age <= 18).ToList();
Console.WriteLine("Danh sach hoc sinh co tuoi tu 15 den 18:");
foreach (var student in youngStudents)
{
    Console.WriteLine($"ID: {student.ID}, Name: {student.Name}, Age: {student.Age}");
}
Console.WriteLine("==================================================\n");

//tim va in ra hoc sinh co ten bat dau bang chu "A"
List<Student> studentsWithA = students.Where(s => s.Name.StartsWith("A")).ToList();
Console.WriteLine("Danh sach hoc sinh co ten bat dau bang chu \"A\":");
foreach (var student in studentsWithA)
{
    Console.WriteLine($"ID: {student.ID}, Name: {student.Name}, Age: {student.Age}");
}
Console.WriteLine("==================================================\n");

//tinh tong tuoi cua cac hoc sinh trong danh sach
int totalAge = students.Sum(s => s.Age);
Console.WriteLine($"Tong tuoi cua cac hoc sinh: {totalAge}");
Console.WriteLine("==================================================\n");

//tim va in ra hoc sinh co tuoi lon nhat
int maxAge = students.Max(s => s.Age);
List<Student> oldestStudents = students.Where(s => s.Age == maxAge).ToList();

Console.WriteLine("Danh sach hoc sinh co tuoi lon nhat:");
foreach (var student in oldestStudents)
{
    Console.WriteLine($"ID: {student.ID}, Name: {student.Name}, Age: {student.Age}");
}
Console.WriteLine("==================================================\n");

//sap xep danh sach hoc sinh theo tuoi tang dan va in ra danh sach hoc sinh sau khi sap xep
List<Student> sortedStudents = students.OrderBy(s => s.Age).ToList();
Console.WriteLine("Danh sach hoc sinh sap xep theo tuoi tang dan:");
foreach (var student in sortedStudents)
{
    Console.WriteLine($"ID: {student.ID}, Name: {student.Name}, Age: {student.Age}");
}
Console.WriteLine("==================================================\n");