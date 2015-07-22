//Task 2. Make_Чуек in C#

using System;

namespace HomeworkNaming
{
    class Personalnformation
    {
        enum Gender { Male, Female };
        class Person
        {
            public Gender gender { get; set; }
            public string name { get; set; }
            public int age { get; set; }
        }
        public void createPerson(int identifier)
        {
            Person individual = new Person();
            individual.age = identifier;
            if (identifier % 2 == 0)
            {
                individual.name = "Батката";
                individual.gender = Gender.Male;
            }
            else
            {
                individual.name = "Мацето";
                individual.gender = Gender.Female;
            }
        }
    }
}
