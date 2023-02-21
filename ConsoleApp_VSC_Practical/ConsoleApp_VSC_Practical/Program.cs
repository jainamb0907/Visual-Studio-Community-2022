// necessary libraries to be used
using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace JsonParser
{
    // Define a class to store values to be converted to JSON  
    class studentInfo
    {
        // Make sure all class attributes have relevant getter setter.
        // Roll Number
        public int Roll { get; set; }
        // Name of the student
        public string name { get; set; }
        // The List of courses studying
        public List<string> courses { get; set; }
    }

    class HelloWorld
    {
        // Main function
        static void Main()
        {
            // Creating a new instance of class studentInfo
            studentInfo student1 = new studentInfo()
            {
                // Roll number
                Roll = 110,
                // Name
                name = "Alex",
                //list of courses
                courses = new List<string>()
      {
        "Math230",
        "Calculus1",
        "CS100",
        "ML"
      }
            };
            Console.WriteLine("Serialization");
            // convert to Json string by seralization of the instance of class.
            


            string stringjson = JsonConvert.SerializeObject(student1);
            Console.WriteLine(stringjson);

            Console.WriteLine("\nDeserialization");
            //convert to Json object by Deseralization of the instance of class.

            studentInfo newstudent1 = JsonConvert.DeserializeObject<studentInfo>(stringjson);
            Console.WriteLine("Student Roll Number: "+newstudent1.Roll);
            Console.WriteLine("Student Name: " + newstudent1.name);
            Console.WriteLine("Student Courses: ");
            foreach (var course in newstudent1.courses)
            {
                Console.WriteLine(course);
            }

        }
    }
}
