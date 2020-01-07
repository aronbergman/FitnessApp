using System;

namespace ClassLibrary.Model
{
    [Serializable]
    public class User
    {
        /// <summary>
        /// Пользователь
        /// </summary>
        public string Name { get; }

        /// <summary>
        /// Пол пользователя
        /// </summary>
        public Gender Gender { get; }

        /// <summary>
        /// Дата рождения пользователя
        /// </summary>
        public DateTime Birthday { get; }

        /// <summary>
        /// Ширина пользователя
        /// </summary>
        public double Weight { get; set; }

        /// <summary>
        /// Высота пользователя
        /// </summary>
        public double Height { get; set; }

        /// <summary>
        /// Создать нового пользователя
        /// </summary>
        /// <param name="name">Имя</param>
        /// <param name="gender">Пол</param>
        /// <param name="birthday">Дата рождения</param>
        /// <param name="weight">Вес пользователя</param>
        /// <param name="height">Рост пользователя</param>
        /// <exception cref="ArgumentNullException"></exception>
        /// <exception cref="ArgumentException"></exception>
        public User(string name, Gender gender, DateTime birthday, double weight, double height)
        {
            #region  Проверка условий

            if (string.IsNullOrWhiteSpace(name))
            {
                throw new ArgumentNullException("Имя пользователя не может быть пустым.", nameof(name));
            }

            if (gender == null)
            {
                throw new ArgumentNullException("Пол не может быть пустым.", nameof(gender));
            }

            if (birthday < DateTime.Parse("01.01.1900") || birthday >= DateTime.Now)
            {
                throw new ArgumentException("Дата рождения не может быть менее 1900 года.", nameof(birthday));
            }

            if (weight <= 30)
            {
                throw new ArgumentException("Вес не может быть меньше 30.", nameof(weight));
            }

            if (height <= 100)
            {
                throw new ArgumentException("Рост не может быть меньше 100.", nameof(height));
            }

            #endregion

            Name = name;
            Gender = gender;
            Birthday = birthday;
            Weight = weight;
            Height = height;
        }

        public override string ToString()
        {
            return Name;
        }
    }
}