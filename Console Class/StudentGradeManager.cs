
using System;
using System.Collections.Generic;

namespace Week11DataStructures
{
    public class StudentGradeManager
    {
        // Store Student ID and Grade as KeyValuePairs
        private List<KeyValuePair<int, double>> students =
            new List<KeyValuePair<int, double>>();

        // =====================================
        // ADD STUDENT PAIR
        // =====================================
        public bool AddStudent(int id, double grade)
        {
            // Validate Student ID and Grade
            if (id <= 0 ||
                double.IsNaN(grade) ||
                double.IsInfinity(grade) ||
                grade < 0 ||
                grade > 100 ||
                Math.Round(grade, 2) != grade)
            {
                return false;
            }

            // Prevent duplicate Student IDs
            foreach (KeyValuePair<int, double> student
                in students)
            {
                if (student.Key == id)
                {
                    return false;
                }
            }

            // Create a KeyValuePair
            KeyValuePair<int, double> newStudent =
                new KeyValuePair<int, double>(id, grade);

            // Add the pair to the collection
            students.Add(newStudent);

            return true;
        }

        // =====================================
        // SEARCH STUDENT
        // =====================================
        public bool SearchStudent(
            int id,
            out KeyValuePair<int, double> foundStudent)
        {
            foreach (KeyValuePair<int, double> student
                in students)
            {
                if (student.Key == id)
                {
                    foundStudent = student;
                    return true;
                }
            }

            foundStudent = default;
            return false;
        }

        // =====================================
        // REMOVE STUDENT PAIR
        // =====================================
        public bool RemoveStudent(int id)
        {
            for (int i = 0; i < students.Count; i++)
            {
                if (students[i].Key == id)
                {
                    students.RemoveAt(i);
                    return true;
                }
            }

            return false;
        }

        // =====================================
        // GET ALL STUDENT PAIRS
        // =====================================
        public List<KeyValuePair<int, double>> GetStudents()
        {
            return new List<KeyValuePair<int, double>>(
                students);
        }

        // =====================================
        // GET TOTAL STUDENT PAIRS
        // =====================================
        public int GetStudentCount()
        {
            return students.Count;
        }
    }
}
