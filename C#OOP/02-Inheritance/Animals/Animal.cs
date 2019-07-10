using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Animals
{
    public class Animal
    {

        public Animal(string name, int age, string gender)
        {
            this.Name = name;
            
            this.Age = age;

            this.Gender = gender;
        }

        [Required(ErrorMessage = "Invalid input!")]        
        public string Name { get; set; }

        [Required()]
        [Range(0, int.MaxValue, ErrorMessage = "Invalid input!" )]
        public int Age { get; set; }
        
        [Required(ErrorMessage = "Invalid input!")]        
        public string Gender { get; set; }


        public virtual string  ProduceSound()
        {
            return "";
        }


    }
}
