using System;
using System.Collections.Generic;
using System.Text;

namespace _58.uzd_Class_Car
{
    public class Car
    {
        // Izveidot klasi Car ar 5 property(īpašībām) Make, Model, Price un Color, Year, izvēlieties atbilstošus 
        // datu tipus izveidotajiem laukiem. 

        public string make { get; set; }
        public string model { get; set; }
        public int price { get; set; }
        public string color { get; set; }
        public int year { get; set; }

        // Pievienojiet šai klases public metodi, kura atgriež visu informāciju par mašīnu kā tekstu, kur visas 
        // vērtības ir atdalītas ar komatu. 

        public string AvailableCars()
        {
            return $"{make}, {model}, {price}, {color}, {year}";
        }
    }
}



// Atrodiet un izdrukājiet uz ekrāna dārgākās mašīnas informāciju. 
// Dārgākās mašīnas atrašanai varat izmantot gan LINQ, gan parastu for vai foreach ciklu.