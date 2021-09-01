using System;
using System.Collections.Generic;
using System.Text;
using ShoppingSiteReplica.Domain; 

namespace ShoppingSiteReplica.Repositories
{
    public interface ICategoryRepository
    {
        List<Category> GetMainCat();
        List<Category> GetSubCat(Guid parentId);
        Guid FindIdByName(CategorySearch category);
        List<Category> Search(CategorySearch category);
        void Insert(Category category);
        void Delete(Guid _id);
        Category FindByID(Guid _id);
        void Update(Category category);
    }
}
