namespace Question1
{
    public class Dog:IAnimal
    {
        public string Name { get; set; }
         public string Habitat { get; set; }
         public string EatingHabit { get; set; }
         public Dog(string Name,string Habitat,string EatingHabit)
         {
            this.Name=Name;
            this.Habitat=Habitat;
            this.EatingHabit=EatingHabit;
         }
        public void DisplayName()
        {
            System.Console.WriteLine("Name    :"+Name);
        }
    }
}