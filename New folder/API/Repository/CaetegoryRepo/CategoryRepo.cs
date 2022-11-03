using API.Server;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Repository.CaetegoryRepo
{
    public class CategoryRepo : ICategoryRepo
    {
        private readonly rapidContext _context;

        public CategoryRepo(rapidContext context)
        {
            _context = context;
        }
        public async Task<List<Categories>> GetCategoriesDB()
        {
            var categoriesList = await _context.Categories.ToListAsync();
            var resultList = new List<Categories>();
            foreach (var Category in categoriesList)
            {
                if(Category.IsActive == true)
                {
                    resultList.Add(Category);
                }
            }
            return  resultList;
        }
    }
}
