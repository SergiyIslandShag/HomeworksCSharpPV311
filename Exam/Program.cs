using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Exam
{
	public class Student
	{
		public string FirstName { get; set; }
		public string LastName { get; set; }
		public DateTime DateOfBirth { get; set; }
		public List<int> Grades { get; set; }

		public Student(string firstName, string lastName, DateTime dateOfBirth, List<int> grades)
		{
			FirstName = firstName;
			LastName = lastName;
			DateOfBirth = dateOfBirth;
			Grades = grades;
		}
		public double CalculateAverageGrade()
		{
			if (Grades == null || Grades.Count == 0)
			{
				return 0;
			}
			return Grades.Average();
		}
		public override string ToString()
        {
            return $"{FirstName} {LastName}, Date of Birth: {DateOfBirth.ToShortDateString()}, Average Grade: {CalculateAverageGrade():F2}";
        }
	}
	public class University
	{
		public List<Student> Students { get; set; }
		public University()
		{
			Students = new List<Student>();
		}
		public void AddStudent(Student student)
		{
			Students.Add(student);
		}
		public override string ToString()
		{
			return string.Join("\n", Students.Select(s => s.ToString()));
		}
		public string ToStringAlphabetical()
		{
			return string.Join("\n", Students.OrderBy(s => s.LastName).ThenBy(s => s.FirstName).Select(s => s.ToString()));
		}
		public Student GetTopStudent()
		{
			return Students.OrderByDescending(s => s.Grades.Average()).FirstOrDefault();
		}
		public List<Student> GetStudentsByName(string name)
		{
			return Students.Where(s => s.FirstName.Equals(name, StringComparison.OrdinalIgnoreCase)).ToList();
		}
		public List<Student> GetBirthdayCelebrants(DateTime date)
		{
			return Students.Where(s => s.DateOfBirth.Day == date.Day && s.DateOfBirth.Month == date.Month).ToList();
		}
		public static University LoadUniversityFromFile(string filePath)
		{
			University university = new University();
			try
			{
				using (StreamReader reader = new StreamReader(filePath))
				{
					string line;
					while ((line = reader.ReadLine()) != null)
					{
						string[] parts = line.Split(',');
						string firstName = parts[0].Trim();
						string lastName = parts[1].Trim();
						DateTime dateOfBirth = DateTime.Parse(parts[2].Trim());
						List<int> grades = parts[3].Trim().Split().Select(int.Parse).ToList();

						Student student = new Student(firstName, lastName, dateOfBirth, grades);
						university.AddStudent(student);
					}
				}
			}
			catch (Exception ex)
			{
				Console.WriteLine($"Error reading from file: {ex.Message}");
			}
			return university;
		}

		public void SaveUniversityToFile(string filePath)
		{
			try
			{
				using (StreamWriter writer = new StreamWriter(filePath))
				{
					foreach (var student in Students)
					{
						writer.WriteLine($"{student.FirstName}, {student.LastName}, {student.DateOfBirth.ToShortDateString()}, {string.Join(" ", student.Grades)}");
					}
				}
			}
			catch (Exception ex)
			{
				Console.WriteLine($"Error saving to file: {ex.Message}");
			}
		}
	}

	class Program
	{
		static void Main(string[] args)
		{
			University university = new University();

			university.AddStudent(new Student("Ivan", "Vintonuk", new DateTime(2001, 5, 17), new List<int> { 90, 85, 88 }));
			university.AddStudent(new Student("Sasha", "Shelepalo", new DateTime(2000, 5, 21), new List<int> { 75, 80, 70 }));
			university.AddStudent(new Student("Sergiy", "Koziar", new DateTime(2000, 5, 21), new List<int> { 95, 98, 92 }));
			university.AddStudent(new Student("Illa", "Melnuk", new DateTime(1999, 5, 12), new List<int> { 85, 89, 90 }));

			string filePath = "students.txt";
			university.SaveUniversityToFile(filePath);

			University loadedUniversity = University.LoadUniversityFromFile(filePath);

			Console.WriteLine("\nInformation about all students:");
			Console.WriteLine(loadedUniversity);

			Console.WriteLine("\nStudents in alphabetical order:");
			Console.WriteLine(loadedUniversity.ToStringAlphabetical());

			Console.WriteLine("\nMost successful student:");
			Student topStudent = loadedUniversity.GetTopStudent();
			Console.WriteLine(topStudent);

			Console.WriteLine("\nStudents named 'Ivan':");
			var studentsNamedIvan = loadedUniversity.GetStudentsByName("Ivan");
			studentsNamedIvan.ForEach(s => Console.WriteLine(s));

			Console.WriteLine("\nBirthday people for May 21:");
			var birthdayCelebrants = loadedUniversity.GetBirthdayCelebrants(new DateTime(2024, 5, 21));
			birthdayCelebrants.ForEach(s => Console.WriteLine(s));
		}
	}
}
