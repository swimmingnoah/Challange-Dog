using System;

namespace Challenge__Dog2
{
    public enum Gender
    {
    Male, 
    Female
    }
    
    public class Dog
    {
        string name;
        string owner;
        int age;
        Gender gender;

        public Dog(string name, string owner, int age, Gender gender)
        {
            this.name = name;
            this.owner = owner;
            this.age = age;
            this.gender = gender;
        }

        public void Bark(int NumberOfBarks)
        {
            int i = 0;

            for(i = 0; i < NumberOfBarks; i++)
            {
                Console.WriteLine("Woof!");
            }
            Console.WriteLine();
        }


        public string GetTag()
        {
            string dogTag;

            dogTag = $"If lost, call {owner}. ";

            if(gender == 0)
            {
                dogTag = dogTag + ($"His name is {name} and he is {age}");
            }
            else
            {
                dogTag = dogTag + ($"Her name is {name} and she is {age}");
            }
            if(age == 1)
            {
                dogTag = dogTag + (" year old.");
            }
            else 
            {
                dogTag = dogTag + (" years old.");
            }
            return dogTag;
        }
    }
    
    
    
    
    
    
    
    class Program
    {
        static void Main(string[] args)
        {
            Dog puppy = new Dog("Orion", "Shawn", 1, Gender.Male);
            puppy.Bark(3); 
            Console.WriteLine(puppy.GetTag());
            
            Console.WriteLine();

            Dog myDog = new Dog("Lileu", "Dale", 4, Gender.Female);
            myDog.Bark(1);
            Console.WriteLine(myDog.GetTag());
        }
    }
}
