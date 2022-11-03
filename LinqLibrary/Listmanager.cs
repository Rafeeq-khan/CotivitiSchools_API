using System;
using System.Collections.Generic;

namespace LinqLibrary
{
    public class Listmanager
    {
        public static List<Category> LoadData()
        {
            List<Category> categoryDetails = new List<Category>();

            categoryDetails.Add(new Category { categoryId = 1, categoryName = "Languages", isActive = true });
            categoryDetails.Add(new Category { categoryId = 2, categoryName = "Web Development", isActive = false });
            categoryDetails.Add(new Category { categoryId = 3, categoryName = "Technologies", isActive = true });
            categoryDetails.Add(new Category { categoryId = 4, categoryName = "Database Tutorials", isActive = true });

            return categoryDetails;
        }
    }
}
