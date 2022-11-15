namespace Question1
{
//     Interface : Animal
// Property: Name, Habitat, Eating Habit 
// Method: DisplayName

    public interface IAnimal
    {
         public string Name { get; set; }
         public string Habitat { get; set; }
         public string EatingHabit { get; set; }
         public void DisplayName();
         
         
    }
}