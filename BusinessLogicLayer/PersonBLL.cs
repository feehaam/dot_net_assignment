using DataAccessLayer.IRepository;
using DataAccessLayer.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicLayer
{
    public class PersonBLL : IPersonBLL
    {

        private readonly ITasksRepo _taskRepo;
        public PersonBLL(ITasksRepo tasksRepo)
        {
            _taskRepo = tasksRepo;
        }
        public bool CreatePerson(Person person)
        {
            return _taskRepo.CreatePerson(person);
        }

        public List<Tasks> GetListOfTasksByName(string Name)
        {
            return _taskRepo.GetListOfTasksByName(Name);
        }

        public List<Tasks> GetListOOfCompleTaskByName(string Name)
        {
            return _taskRepo.GetListOOfCompleTaskByName(Name);
        }

        public Person GetPersonByName(string name)
        {
            return _taskRepo.GetPersonByName(name);
        }

        public List<Person> GetTasks()
        {
            return _taskRepo.GetTasks();
        }

        public bool PersonExists(string name)
        {
            return _taskRepo.PersonExists(name);
        }
    }
}
