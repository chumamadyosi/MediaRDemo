using DemoLibrary.Models;
using System.Collections.Generic;

namespace DemoLibrary.DataAccess
{
    public interface IDataAccess
    {
        List<PersonModel> GetPeople();
        PersonModel InserPerson(string Name, string LastName);
        PersonModel GetPersonById(int Id);
    }
}