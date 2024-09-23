using System.ComponentModel.DataAnnotations;


namespace Unit1Proj.Models
{
    public class Methods
    {

        public string Name { get; set;  }
        public string Fighter()
        {
            return this.Name + " Won't Beat Sora, I'm Sora sorry";
        }

    }

}
