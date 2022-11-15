namespace Question1
{
    public class Duck
    {
        public string Name { get; set; }
         public string Habitat { get; set; }
         public string EatingHabit { get; set; }
         public Duck(string Name,string Habitat,string EatingHabit)
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