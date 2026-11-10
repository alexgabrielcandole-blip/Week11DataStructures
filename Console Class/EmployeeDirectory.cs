
using System;
using System.Collections;

namespace Week11DataStructures
{
    public class EmployeeDirectory : DictionaryBase
    {
        // =====================================
        // VALIDATE EMPLOYEE DATA
        // =====================================
        protected override void OnValidate(
            object key, object value)
        {
            if (key is not int id || id <= 0)
            {
                throw new ArgumentException(
                    "Employee ID must be a positive number.");
            }

            if (value is not string name ||
                string.IsNullOrWhiteSpace(name))
            {
                throw new ArgumentException(
                    "Employee name cannot be empty.");
            }

            base.OnValidate(key, value);
        }

        // =====================================
        // ADD EMPLOYEE
        // =====================================
        public bool AddEmployee(int id, string name)
        {
            name = name.Trim();

            if (id <= 0 || name == "")
            {
                return false;
            }

            // Employee IDs must be unique.
            if (Dictionary.Contains(id))
            {
                return false;
            }

            Dictionary.Add(id, name);

            return true;
        }

        // =====================================
        // SEARCH EMPLOYEE
        // =====================================
        public bool SearchEmployee(int id, out string name)
        {
            name = "";

            if (Dictionary.Contains(id))
            {
                name = (string)Dictionary[id]!;
                return true;
            }

            return false;
        }

        // =====================================
        // REMOVE EMPLOYEE
        // =====================================
        public bool RemoveEmployee(int id)
        {
            if (!Dictionary.Contains(id))
            {
                return false;
            }

            Dictionary.Remove(id);

            return true;
        }

        // =====================================
        // GET ALL EMPLOYEE RECORDS
        // =====================================
        public DictionaryEntry[] GetEmployees()
        {
            DictionaryEntry[] employees =
                new DictionaryEntry[Count];

            int index = 0;

            foreach (DictionaryEntry entry in Dictionary)
            {
                employees[index] = entry;
                index++;
            }

            return employees;
        }

        // =====================================
        // GET TOTAL EMPLOYEES
        // =====================================
        public int GetEmployeeCount()
        {
            return Count;
        }
    }
}
