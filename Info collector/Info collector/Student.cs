using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Info_collector
{
    internal class Student
    {
        public string _name;
        public string _id;
        public int _by;
        public double _height;
        public double _grade;
        public string _degree;

        public string NAME
        {
            get { return _name; }
        }
        public string id
        {
            get { return _id; }
        }
        public int by
        {
            get { return _by; }
        }
        public double height
        {
            get { return _height; }
        }
        public double grade
        {
            get { return _grade; }
        }
        public string degree
        {
            get { return _degree; }
        }

        public Student(string name, string id, int by, double height, double grade, string degree)
        {
            this._name = name;
            this._id = id;
            this._by = by;
            this._height = height;
            this._grade = grade;
            this._degree = degree;
        }
    }
}
