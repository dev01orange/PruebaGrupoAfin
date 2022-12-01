﻿using System.Collections.Generic;

namespace PruebaGA_API.Models
{
    public class CountryModel
    {
        public string name { get; set; }
        public List<string> topLevelDomain { get; set; }
        public string alpha2Code { get; set; }
        public string alpha3Code { get; set; }
        public List<string> callingCodes { get; set; }
        public string capital { get; set; }
        public List<string> altSpellings { get; set; }
        public string subregion { get; set; }
        public string region { get; set; }
        public int population { get; set; }
        public List<double> latlng { get; set; }
        public string demonym { get; set; }
        public double area { get; set; }
        public double gini { get; set; }
        public List<string> timezones { get; set; }
        public List<string> borders { get; set; }
        public string nativeName { get; set; }
        public string numericCode { get; set; }
        public Flags flags { get; set; }
        public List<Currencies> currencies { get; set; }
        public List<languages> languages { get; set; }
        public Translations translations { get; set; }
        public string flag { get; set; }
        public string cioc { get; set; }
        public bool independent { get; set; }
    }

    public class Flags
    {
        public string svg { get; set; }
        public string png { get; set; }
    }

    public class Currencies
    {
        public string code { get; set; }
        public string name { get; set; }
        public string symbol { get; set; }
    }

    public class languages
    {
        public string iso639_1 { get; set; }
        public string iso639_2 { get; set; }
        public string name { get; set; }
        public string nativeName { get; set; }
    }

    public class Translations
    {
        public string br { get; set; }
        public string pt { get; set; }
        public string nl { get; set; }
        public string hr { get; set; }
        public string fa { get; set; }
        public string de { get; set; }
        public string es { get; set; }
        public string fr { get; set; }
        public string ja { get; set; }
        public string it { get; set; }
        public string hu { get; set; }
    }

    
}
