using System;
using System.Collections.Generic;
using System.Text;

namespace AppOOP
{
    class Student
    {
        private string Name;

        public string StudentName
        {
            get { return Name; }
            set { Name = value; }
        }

        public Student(string stName)
        {
            this.Name = stName;
        }

        public Student()
        {
        }

        public virtual void Talk()
        {
            if (StudentName.Equals("Minh"))
                System.Windows.MessageBox.Show("My name is " + this.StudentName + " i am a college student");
            else if (StudentName.Equals("Dung"))
                System.Windows.MessageBox.Show("My name is " + this.StudentName + " i am a university student");
        }
    }
}