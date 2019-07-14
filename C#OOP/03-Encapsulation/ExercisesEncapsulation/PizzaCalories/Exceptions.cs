using System;
using System.Collections.Generic;
using System.Text;

namespace PizzaCalories
{
    public class Exceptions
    {
        public static string invalidDough = "Invalid type of dough.";
        public static string invalidWeight = "Dough weight should be in the range [1..200].";
        public static string invalidName = "Pizza name should be between 1 and 15 symbols.";
        public static string toppingsRange = "Number of toppings should be in range [0..10].";

    }
}
