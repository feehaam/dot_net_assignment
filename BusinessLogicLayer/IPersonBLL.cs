using DataAccessLayer.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicLayer
{
    public interface IPersonBLL
    {
        List<Person> GetTasks();
        bool CreatePerson(Person person);
        Person GetPersonByName(string name);

        List<Tasks> GetListOfTasksByName(string Name);

        List<Tasks> GetListOfCompleTaskByName(string Name);
        bool PersonExists(string name);
    }
}
