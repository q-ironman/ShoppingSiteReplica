using ShoppingSiteReplica.Domain;
using ShoppingSiteReplica.Repositories;
using System;
using System.Collections.Generic;
using System.Text;

namespace ShoppinSiteReplica.Services
{
    public class CategoryService : ICategoryService
    {
        public void Delete(Guid _id)
        {
            var myrepo = ServiceActivator.Get<ICategoryRepository>();
            myrepo.Delete(_id);
        }

        public Category FindByID(Guid _id)
        {
            var myrepo = ServiceActivator.Get<ICategoryRepository>();
            return myrepo.FindByID(_id);
        }

        public Guid FindIdByName(CategorySearch categorySearch)
        {
            var myrepo = ServiceActivator.Get<ICategoryRepository>();
            return myrepo.FindIdByName(categorySearch);
        }

        public List<Category> GetMainCat()
        {      
            var myrepo = ServiceActivator.Get<ICategoryRepository>();
            return myrepo.GetMainCat();
        }

        public List<Category> GetSubCat(Guid parentId)
        {
            var myrepo = ServiceActivator.Get<ICategoryRepository>();
            return myrepo.GetSubCat(parentId);

        }

        public void Insert(Category category)
        {
            var myrepo = ServiceActivator.Get<ICategoryRepository>();
            myrepo.Insert(category);
        }

        public List<Category> Search(CategorySearch categorySearch)
        {
            var myrepo = ServiceActivator.Get<ICategoryRepository>();
            return myrepo.Search(categorySearch);
        }
        public void Update(Category category)
        {
            var myrepo = ServiceActivator.Get<ICategoryRepository>();
            myrepo.Update(category);
        }


    }
}
