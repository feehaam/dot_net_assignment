
using DataAccessLayer.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.IRepository
{
    public interface ITasksRepo
    {
        List<Person> GetTasks();
        bool CreatePerson(Person person);
        Person GetPersonByName(string name);

        List<Tasks> GetListOfTasksByName(string Name);

        List<Tasks> GetListOOfCompleTaskByName(string Name);
        bool PersonExists(string name);
        bool Save();
    }
}
