
using System;
using System.Collections.Generic;

namespace Week11DataStructures
{
    public class CountryPairManager
    {
        // Store Country Code and Country Name pairs
        private List<KeyValuePair<string, string>> countries =
            new List<KeyValuePair<string, string>>();

        // =====================================
        // VALIDATE COUNTRY CODE
        // =====================================
        public static bool IsValidCountryCode(string code)
        {
            if (string.IsNullOrWhiteSpace(code))
            {
                return false;
            }

            code = code.Trim().ToUpperInvariant();

            // Must contain exactly two letters: A-Z
            if (code.Length != 2)
            {
                return false;
            }

            foreach (char letter in code)
            {
                if (letter < 'A' || letter > 'Z')
                {
                    return false;
                }
            }

            return true;
        }

        // =====================================
        // ADD COUNTRY PAIR
        // =====================================
        public bool AddCountry(string code, string name)
        {
            code = code.Trim().ToUpperInvariant();
            name = name.Trim();

            // Validate country code and name
            if (!IsValidCountryCode(code) || name == "")
            {
                return false;
            }

            // Prevent duplicate country codes
            foreach (KeyValuePair<string, string> country
                in countries)
            {
                if (string.Equals(
                    country.Key,
                    code,
                    StringComparison.OrdinalIgnoreCase))
                {
                    return false;
                }
            }

            // Create a new KeyValuePair
            KeyValuePair<string, string> newCountry =
                new KeyValuePair<string, string>(
                    code, name);

            // Add the pair to our list
            countries.Add(newCountry);

            return true;
        }

        // =====================================
        // SEARCH COUNTRY
        // =====================================
        public bool SearchCountry(
            string code,
            out KeyValuePair<string, string> foundCountry)
        {
            code = code.Trim().ToUpperInvariant();

            foreach (KeyValuePair<string, string> country
                in countries)
            {
                if (string.Equals(
                    country.Key,
                    code,
                    StringComparison.OrdinalIgnoreCase))
                {
                    foundCountry = country;
                    return true;
                }
            }

            foundCountry = default;
            return false;
        }

        // =====================================
        // REMOVE COUNTRY PAIR
        // =====================================
        public bool RemoveCountry(string code)
        {
            code = code.Trim().ToUpperInvariant();

            for (int i = 0; i < countries.Count; i++)
            {
                if (string.Equals(
                    countries[i].Key,
                    code,
                    StringComparison.OrdinalIgnoreCase))
                {
                    countries.RemoveAt(i);
                    return true;
                }
            }

            return false;
        }

        // =====================================
        // GET ALL COUNTRY PAIRS
        // =====================================
        public List<KeyValuePair<string, string>> GetCountries()
        {
            return new List<KeyValuePair<string, string>>(
                countries);
        }

        // =====================================
        // GET TOTAL COUNTRY PAIRS
        // =====================================
        public int GetCountryCount()
        {
            return countries.Count;
        }
    }
}
