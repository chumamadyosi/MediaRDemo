using DemoLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoLibrary.DataAccess
{
    public class DemoDataAccess : IDataAccess
    {
        private List<PersonModel> people = new();

        public DemoDataAccess()
        {
            people.Add(new PersonModel { Id = 1, LastName = "Tim", FirstName = "Corey" });
            people.Add(new PersonModel { Id = 2, LastName = "Sue", FirstName = "Storm" });
        }
        public List<PersonModel> GetPeople() { return people; }

        public PersonModel GetPersonById(int Id)
        {
            var person = people.FirstOrDefault(x => x.Id == Id);
            if (person != null)
            {
                return person;
            }
            return null;
        }

        public PersonModel InserPerson(string Name, string LastName)
        {
            PersonModel person = new() { Id = people.Max(x => x.Id), FirstName = Name, LastName = LastName };
            people.Add(person);

            return person;
        }
    }
}
