using API.Repository.SkillRepo;
using API.VarTutorialsData;
using LinqLibrary;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Categories
{
    class Program
    {
        static void Main(ISkillRepo skillRepo)
        {
            List<Category> category = Listmanager.LoadData();

            category = category.OrderByDescending(c => c.isActive).ToList();

            category = category.Where(c => c.isActive == true).ToList();


            foreach (Category item in category)
            {
                Console.WriteLine($"{ item.categoryId} {item.categoryName }  { item.isActive} ,");
            }

            //List<Skills> skillList = skillRepo.GetSkillsbyCatDB(1);
        }
    }
}
