﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionsAssignment_2
{
    class Program2
    {
        static bool keyIsAlreadyDictionary(Dictionary<string, string> countries, string country)
        {
            if (countries.ContainsKey(country))
            {
                throw new ArgumentException("This key " + country + " is already in dictionary");
            }
            return false;
        }
        static void Main(string[] args)
        {
            Dictionary<string, string> countries = new Dictionary<string, string>();
            countries.Add("India", "Delhi");
            countries.Add("China", "Beijing ");
            countries.Add("Chile", "Santiago");
            countries.Add("USA", "Washington");
            countries.Add("Thailand", "Bangkok");
            countries.Add("South Korea", "Seoul");
            countries.Add("Serbia", "Belgrade");
            countries.Add("Brazil", "Brasília");
            try
            {
                if (!keyIsAlreadyDictionary(countries, "Brazil"))
                {
                    countries.Add("Brazil", "Brasília");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            if (countries.ContainsKey("India"))
            {
                countries["India"] = "New Delhi";
                Console.WriteLine("The capital of country India has been changed. A new capital is " + countries["India"] + "\n");
            }
            try
            {
                if (!keyIsAlreadyDictionary(countries, "Poland"))
                {
                    countries.Add("Poland", "Warsaw");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            Console.WriteLine();
            foreach (string key in countries.Keys)
            {
                Console.WriteLine(string.Format("{0,-20} {1,-20}", key, countries[key]));
            }
            Console.WriteLine();
            if (countries.ContainsKey("Chile"))
            {
                countries.Remove("Chile");
                Console.WriteLine("The entry for Chile has been deleted.");
            }
            else
            {
                Console.WriteLine("The dictionary does not contain the key Chile");
            }
            Console.WriteLine();
            foreach (string key in countries.Keys)
            {
                Console.WriteLine(string.Format("{0,-20} {1,-20}", key, countries[key]));
            }
            try
            {
                Console.WriteLine(countries["India 1"]);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            Console.ReadLine();
        }
    }
}
