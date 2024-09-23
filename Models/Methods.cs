using System.ComponentModel.DataAnnotations;


namespace Unit1Proj.Models
{
    public class Methods
    {

        public string Name { get; set;  }
        public string Fighter(string Name)
        {
            Name = Name + "Won't Beat Sora, I'm Sora sorry";

            return Name;
        }

    }

}
