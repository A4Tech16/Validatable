using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;


namespace Validatable
{
    public static class CarValidator
    {
        public static List<string> ValidateCar(this IValidatable validatable)
        {
            List<string> errors = new List<string>();

            var type = validatable.GetType();
            var properties = type.GetProperties();

            foreach (var property in properties)
            {
                var attrs = property.GetCustomAttributes(false);

                foreach (var a in attrs)
                {
                    if (a is MinLengthAttribute minLength)
                    {
                        {
                            if (!minLength.IsValid(property.GetValue(validatable)))
                            {
                                errors.Add($"{property.Name} Некорекктное название");
                            }
                        }






                        /*if (property.Name == "NameCar")
                        {
                            if (!minLength.IsValid(validatable.NameCar))
                            {
                                errors.Add($"{property.Name} Некоректное название машины");
                            }
                        }

                        if (property.Name == "Model")
                        {
                            if (!minLength.IsValid(validatable.Model))
                            {
                                errors.Add($"{property.Name} Отсутствует модель машины");
                            }
                        }
                    }

                    if (a is RequiredAttribute required)
                    {
                        if (property.Name == "NameCar")
                        {
                            if (!required.IsValid(validatable.NameCar))
                            {
                                errors.Add($"{property.Name} Отсутствует название машины");
                            }
                        }

                        if (property.Name == "Model")
                        {
                            if (!required.IsValid(validatable.Model))
                            {
                                errors.Add($"{property.Name} В поле Модель пусто");
                            }
                        }

                    }*/
                    }
                }
            }

            return errors;
        }
    }
}
