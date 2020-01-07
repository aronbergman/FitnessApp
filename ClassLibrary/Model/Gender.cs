using System;

namespace ClassLibrary.Model
{
    /// <summary>
    /// Пол
    /// </summary>
    public class Gender
    {
        /// <summary>
        /// Наименование пола
        /// </summary>
        public string Name { get; }

        /// <summary>
        /// Создать новое наименование пола
        /// </summary>
        /// <param name="name"> Имя пола. </param>
        /// <exception cref="ArgumentNullException"></exception>
        public Gender(string name)
        {
            if (!string.IsNullOrWhiteSpace(name))
            {
                Name = name;
            }
            else
            {
                throw new ArgumentNullException("Имя пола не может быть пустым", nameof(name));
            }
        }
    }
}