using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.Average_Grades
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] readAllText = File.ReadAllLines("Input.txt");

            int numberOfStudents = int.Parse(readAllText[0]);

            List<Students> listOfStudents = new List<Students>();



            for (int i = 0; i < numberOfStudents; i++)

            {

                Students students = new Students();

                string[] input = readAllText[i + 1].Split(' ');

                students.Name = input[0];

                students.ListOfGrades = input.Skip(1).Select(double.Parse).ToArray();

                listOfStudents.Add(students);

            }



            var result = listOfStudents.Where(x => x.Avarage >= 5.00)

                .OrderBy(x => x.Name)

                .ThenByDescending(x => x.Avarage)

                .ToList();



            foreach (var item in result)

            {

                File.AppendAllText("output.txt", $"{item.Name} -> {item.Avarage:F2}" + Environment.NewLine);

            }

        }

        class Students

        {

            public string Name { get; set; }

            public double[] ListOfGrades { get; set; }

            public double Avarage => ListOfGrades.Average();
        }
    }
}
