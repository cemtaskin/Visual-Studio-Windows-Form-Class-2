using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListOfItems.models
{
    public class Student
    {
        public string Number{ get; set; }
        public string NameSurname { get; set; }
        public double MidTerm { get; set; }
        public double Final { get; set; }
        public double ExamResult { get { return MidTerm * 0.3 + Final * 0.7;   } }
        public string State { get { return ExamResult >= 60 ? "Success" : "Failure"; } }

        public Student()
        {
            Number = "";
            NameSurname = "";
        }

        public static void saveData(List<Student> students)
        {
            File.WriteAllText("data.txt", JsonConvert.SerializeObject(students));
        }

        public static List<Student> readData()
        {
            try
            {
                return JsonConvert.DeserializeObject<List<Student>>(File.ReadAllText("data.txt"));
            }
            catch { }
            return new List<Student>();
        }
    }
}
