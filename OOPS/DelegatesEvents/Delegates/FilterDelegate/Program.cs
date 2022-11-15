using System;
namespace FilterDelegate;
public delegate bool MyFilterDelegate(Person p);
class Program{
    public static void Main(string[] args)
    {
        Person person1=new Person(){Name="Arun",Age=21};
        Person person2=new Person(){Name="Jane",Age=69};
        Person person3=new Person(){Name="Jake",Age=12};
        Person person4=new Person(){Name="Vikram",Age=30};
        Person person5=new Person(){Name="Senthil",Age=50};
        Person person6=new Person(){Name="Ganesh",Age=41};
        List<Person> people=new List<Person>(){person1,person2,person3,person4,person5,person6};
        
        DisplayPeople("Children:",people,Ischild);
        DisplayPeople("Adult:",people,IsAdult);
        DisplayPeople("Senior:",people,IsSenior);
        DisplayPeople("voter:",people,IsVoter);

    }
    static void DisplayPeople(string title,List<Person> people,MyFilterDelegate filter)
    {
        System.Console.WriteLine("People in"+title+"list are:");
        foreach(Person p in people)
        {
            if(filter(p))
            {
                System.Console.WriteLine("{0}, is {1} years old",p.Name,p.Age);
            }
        }
    }
    static bool Ischild(Person p){return p.Age<15;}
    static bool IsVoter(Person p){return p.Age>=18;}
    static bool IsSenior(Person p){return p.Age>=50;}
    static bool IsAdult(Person p){return p.Age>=18 && p.Age<50;}
}

