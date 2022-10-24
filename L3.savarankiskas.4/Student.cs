using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace L3.savarankiskas._4
{
    internal class Student
    {     
        public string Surname { get; set; }
        public string Name { get; set; }
        public string Group { get; set; }
        public int GradeCount { get; set; }
        public int[] Grade{ get; set; }    
        public int Average { get; set; }
        public Student(string surname, string name,string group, int gradeCount, int[] grade)
        {        
            this.Surname = surname;
            this.Name = name;
            this.Group = group;
            this.GradeCount = gradeCount;
            this.Grade = grade;
            Avg();
        }
        public void Avg()
        {
            int average = 0;
            for(int i=0;i<GradeCount;i++)
            {
                average += Grade[i];
            }
            this.Average = average / GradeCount;
        }
        public int CompareTo(Student other)                            
        {
            if (this.Average.CompareTo(other.Average) == 0)
            {
                return this.Surname.CompareTo(other.Surname);
            }
            else
            {
                return this.Average.CompareTo(other.Average);
            }
        }
        public override bool Equals(object obj)
        {
            return obj is Student student &&        
                   Surname == student.Surname &&
                   Group == student.Group &&
                   GradeCount == student.GradeCount &&
                   EqualityComparer<int[]>.Default.Equals(Grade, student.Grade);
        }

        public override int GetHashCode()
        {
            int hashCode = 623695960;      
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Surname);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Group);
            hashCode = hashCode * -1521134295 + GradeCount.GetHashCode();
            hashCode = hashCode * -1521134295 + EqualityComparer<int[]>.Default.GetHashCode(Grade);
            return hashCode;
        }

        public override string ToString()
        {
            string line;
            string grades = "";
            for(int i=0;i<this.GradeCount;i++)
            {
                grades += this.Grade[i] + " ";
            }
            line = string.Format("{0,-20}|{1,-20}|{2,-20}|{3,20}|{4,20}|{5,8}|", this.Surname, this.Name, this.Group, this.GradeCount,grades, this.Average);
            return line;
        }
    }
}
