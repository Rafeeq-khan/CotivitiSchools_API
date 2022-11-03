using API.Server;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Repository.CaetegoryRepo
{
    public interface ICategoryRepo
    {
        public  Task<List<Categories>> GetCategoriesDB();
    }
}
