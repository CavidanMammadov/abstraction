﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student.cs
{
    internal class Student
    {
        private static int _idCounter = 1;
        public int Id { get; }
        public string Fullname { get; set; }
        public double Point { get; set; }

        public Student(string fullname, double point)
        {
            Id = _idCounter++;
            Fullname = fullname;
            Point = point;
        }

        public void StudentInfo()
        {
            Console.WriteLine($"Id: {Id}, Fullname: {Fullname}, Point: {Point}");
        }
    }
}