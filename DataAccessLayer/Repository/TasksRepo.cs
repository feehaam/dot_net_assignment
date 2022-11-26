﻿using asingment.Model;
using DataAccessLayer.IRepository;
using DataAccessLayer.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Repository
{
    public class TasksRepo : ITasksRepo
    {
        private readonly DataContext _context;
        public TasksRepo(DataContext context)
        {
            _context = context;
        }

        public bool CreatePerson(Person person)
        {
            _context.Add(person);
            return Save();
        }

        public List<Tasks> GetListOfTasksByName(string Name)
        {
            return _context.Tasks.Where(i => i.OrderFor == Name).ToList();
        }


        public List<Tasks> GetListOOfCompleTaskByName(string Name)
        {
            var x = _context.Tasks.Where(i => i.IsComplete == true).ToList();
            return x.Where(i => i.OrderFor == Name).ToList();
        }

        public Person GetPersonByName(string name)
        {
            return _context.Persons.Where(i => i.Name == name).Include(i => i.Orders).FirstOrDefault();
        }

        public List<Person> GetTasks()
        {
            return _context.Persons.OrderBy(j => j.Id).Include(i => i.Orders).ToList();
            
        }

        public bool PersonExists(string name)
        {
            //return _context.Tasks.Any(i => i.OrderFor == name);
            return _context.Persons.Any(x => x.Name == name);
        }

        public bool Save()
        {
            var saved = _context.SaveChanges();
            return saved > 0 ? true : false;
        }

    }
}
