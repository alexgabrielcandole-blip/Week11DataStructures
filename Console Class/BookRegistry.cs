
using System;
using System.Collections;
using System.Text.RegularExpressions;

namespace Week11DataStructures
{
    public class BookRegistry : DictionaryBase
    {
        // =====================================
        // VALIDATE BOOK CODE FORMAT
        // =====================================
        public static bool IsValidBookCode(string code)
        {
            if (string.IsNullOrWhiteSpace(code))
            {
                return false;
            }

            code = code.Trim().ToUpperInvariant();

            // Required format: BK-001, BK-002, etc.
            return Regex.IsMatch(code, @"^BK-[0-9]{3}$");
        }

        // =====================================
        // CUSTOM DICTIONARY VALIDATION
        // =====================================
        protected override void OnValidate(
            object key, object value)
        {
            if (key is not string code ||
                !IsValidBookCode(code))
            {
                throw new ArgumentException(
                    "Invalid book code. Use BK-001 format.");
            }

            if (value is not string title ||
                string.IsNullOrWhiteSpace(title))
            {
                throw new ArgumentException(
                    "Book title cannot be empty.");
            }

            base.OnValidate(key, value);
        }

        // =====================================
        // ADD BOOK
        // =====================================
        public bool AddBook(string code, string title)
        {
            code = code.Trim().ToUpperInvariant();
            title = title.Trim();

            if (!IsValidBookCode(code) || title == "")
            {
                return false;
            }

            // Prevent duplicate book codes
            if (Dictionary.Contains(code))
            {
                return false;
            }

            Dictionary.Add(code, title);

            return true;
        }

        // =====================================
        // SEARCH BOOK
        // =====================================
        public bool SearchBook(string code, out string title)
        {
            code = code.Trim().ToUpperInvariant();
            title = "";

            if (Dictionary.Contains(code))
            {
                title = (string)Dictionary[code]!;
                return true;
            }

            return false;
        }

        // =====================================
        // REMOVE BOOK
        // =====================================
        public bool RemoveBook(string code)
        {
            code = code.Trim().ToUpperInvariant();

            if (!Dictionary.Contains(code))
            {
                return false;
            }

            Dictionary.Remove(code);

            return true;
        }

        // =====================================
        // GET ALL REGISTERED BOOKS
        // =====================================
        public DictionaryEntry[] GetBooks()
        {
            DictionaryEntry[] books =
                new DictionaryEntry[Count];

            int index = 0;

            foreach (DictionaryEntry entry in Dictionary)
            {
                books[index] = entry;
                index++;
            }

            return books;
        }

        // =====================================
        // GET TOTAL REGISTERED BOOKS
        // =====================================
        public int GetBookCount()
        {
            return Count;
        }
    }
}
