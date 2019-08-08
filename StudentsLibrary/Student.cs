using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentsLibrary
{
    public class Student
    {
        private string _firstname;
        private string _lastname;
        private long _id;
        private string _program;
        private List<string> _courses;

        //custom constructor
        public Student(string firstname,string lastname,long id, string program)
        {
            this._firstname = firstname;
            _lastname = lastname;
            _id = id;
            this._program = program;
            _courses = new List<string>();
        }
        //properties
        public string Firstname
        {
            get{return _firstname;}
        }
        public string Lastname
        {
            get { return _lastname; }
        }
        public string Program
        {
            get { return _program; }
            set
            {
                _program = value; //value is a keyword
                                  //a place holder for the
                                  //real value 

            }
        }
        public long ID
        {
            get { return _id; }
        }

        public string[] courses
        {
            get { return _courses.ToArray(); }
        }
        //methods to add and remove courses
        public void AddCourse(string course)
        {
            //add the course, _courses list
            _courses.Add(course);
        }

        public void RemoveCourse(string course)
        {
            _courses.Remove(course);
        }
    }
}
