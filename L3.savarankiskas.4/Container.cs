using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace L3.savarankiskas._4
{
    class Container
    {
        public string Faculty { get; set;}
        private Student[] students;
        private int Capacity;
        public int Count { get; private set; }
        private void EnsureCapacity(int minimumCapacity)
        {
            if (minimumCapacity > this.Capacity)
            {
                Student[] temp = new Student[minimumCapacity];
                for (int i = 0; i < this.Count; i++)
                {
                    temp[i] = this.students[i];
                }
                this.Capacity = minimumCapacity;
                this.students = temp;
            }
        }

        public Container()
        {
            this.students = new Student[16];
        }
        public void Add(Student student)
        {
            if (this.Count == this.Capacity)
            {
                EnsureCapacity(this.Capacity * 2);
            }
            this.students[this.Count++] = student;
        }
        public void Put(Student student, int index)
        {
            if (this.Count == this.Capacity)
            {
                EnsureCapacity(this.Capacity * 2);
            }
            if (index > this.Count)
            {
                this.students[this.Count++] = student;
            }
            else
            {
                this.students[index] = student;
            }
        }
        public Student Get(int index)
        {
            return this.students[index];
        }
        public void Sort()
        {
            bool flag = true;
            while (flag)
            {
                flag = false;
                for (int i = 0; i < this.Count - 1; i++)
                {
                    Student a = this.students[i];
                    Student b = this.students[i + 1];
                    if (a.CompareTo(b) > 0)
                    {
                        this.students[i] = b;
                        this.students[i + 1] = a;
                        flag = true;
                    }
                }
            }
        }
    }
}
