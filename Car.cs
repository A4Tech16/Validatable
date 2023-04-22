using System.ComponentModel.DataAnnotations;


namespace Validatable
{
    public class AddCar : IValidatable
    {
        [MinLength(3)]
        [Required(AllowEmptyStrings = false)]
        public string NameCar { get; set; }
        [MinLength(1)]
        [Required(AllowEmptyStrings = false)]
        public string Model { get; set; }   

        public AddCar(string name, string model)
        {
            NameCar = name;
            Model = model;
        }
    }
}
