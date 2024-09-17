using MoviesRental.Core.DomainObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace MoviesRental.Domain.Entities
{
    public class Director : Entity
    {
        protected Director() { }

        public Director(
            string name,
            string surname)
        {
            UpdateName(name);
            UpdateSurname(surname);

        }

        public string Name { get; private set; }
        public string Surname { get; private set; }

        public const int MIN_LENGTH = 3;
        public const int MAX_LENGHT = 30;


        public List<Dvd> _dvds = new List<Dvd>();

        public IReadOnlyList<Dvd> Dvds => _dvds;

        public string FullName()
        {
            return $"{Name} {Surname}";

        }

        public void UpdateName(string name)
        {
            if (!ValidateName(name))
                throw new DomainException($"Ivalid name of Director");
            Name = name;
        }
        public void UpdateSurname(string surname)
        {
            if (!ValidateName(surname))
                throw new DomainException(($"Ivalid name of Director"));
            Surname = surname;
        }

        private bool ValidateName(string value)
        {
            if (string.IsNullOrEmpty(value) || value.Length < MIN_LENGTH || value.Length > MAX_LENGHT) return false;

            return Regex.IsMatch(value, "^(?=.*[A-ZÀ-Ÿ])(?=.*[a-zà-ÿ])[A-Za-zÀ-ÿ]+$");

        }
    }
}
