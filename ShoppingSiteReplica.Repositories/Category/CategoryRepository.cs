using ShoppingSiteReplica.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Linq;

namespace ShoppingSiteReplica.Repositories
{
    public class CategoryRepository : ICategoryRepository
    {
        string path = @"C:\Users\osman\Desktop\Lectures\C#\ShoppingSiteReplica\Catogaries.xml";
        XElement doc;
        public CategoryRepository()
        {
            doc = XElement.Load(path);
        }

        public Guid FindIdByName(CategorySearch category)
        {
            var element = doc.Elements("Category").FirstOrDefault(x => x.Element("Name").Value == category.Name);
            var findingID = Guid.Parse(element.Element("ID").Value);
            return findingID;
        }

        public List<Category> GetMainCat()
        {
            List<Category> mainCats = new List<Category>();
            IEnumerable<XElement> res = null;

            res = from category in doc.Elements("Category")
                  where category.Element("ParentID").Value == ""
                  select category;

            foreach(var cat in res)
            {
                var tmp = new Category();
                tmp.ID = Guid.Parse(cat.Element("ID").Value);
                tmp.Name = cat.Element("Name").Value;
                mainCats.Add(tmp);
            }


            return mainCats;
        }

        public List<Category> GetSubCat(Guid parentId)
        {
            List<Category> subCats = new List<Category>();
            IEnumerable<XElement> res;

            res = from category in doc.Elements("Category")
                  where category.Element("ParentID").Value == parentId.ToString()
                  select category;

            foreach (var cat in res)
            {
                var tmp = new Category();
                tmp.ID = Guid.Parse(cat.Element("ID").Value);
                tmp.Name = cat.Element("Name").Value;
                tmp.ParentID = Guid.Parse(cat.Element("ParentID").Value);
                subCats.Add(tmp);
            }

            return subCats;
        }
        public List<Category> Search (CategorySearch categorySearch)
        {
            List<Category> srchRes = new List<Category>();
            IEnumerable<XElement> res;

            res = from category in doc.Elements("Category")
                  where category.Element("Name").Value == categorySearch.Name
                  select category;

            foreach (var cat in res)
            {
                var tmp = new Category();
                tmp.ID = Guid.Parse(cat.Element("ID").Value);
                tmp.Name = cat.Element("Name").Value;
                Guid parentID;
                if(Guid.TryParse(cat.Element("ParentID").Value, out parentID))
                {
                    tmp.ParentID = parentID;
                }
                else
                {
                    tmp.ParentID = null;
                }
                srchRes.Add(tmp);
            }


            return srchRes;
        }
        public void Insert(Category category)
        {
            doc.Add(new XElement("Category",
                new XElement("ID", category.ID),
                new XElement("Name", category.Name),
                new XElement("ParentID", category.ParentID)));
            doc.Save(path);
        }
        public void Delete(Guid _id)
        {
            doc.Descendants("Category").Single(x => x.Element("ID").Value == _id.ToString()).Remove();
            doc.Save(path);
        }

        public Category FindByID(Guid _id)
        {
            var element = doc.Elements("Category").FirstOrDefault(x => x.Element("ID").Value == _id.ToString());
            var res = new Category();
            res.ID = Guid.Parse(element.Element("ID").Value);
            res.Name = element.Element("Name").Value;
            Guid outID;
            if (Guid.TryParse(element.Element("ParentID").Value, out outID))
            {
                res.ParentID = outID;
            }
            else
            {
                res.ParentID = null;
            }
            return res;
        }

        public void Update(Category category)
        {
            Guid updId = category.ID;
            var element = doc.Descendants("Category").Single(x => x.Element("ID").Value == updId.ToString());
            element.Element("Name").Value = category.Name;
            element.Element("ParentID").Value = category.ParentID.ToString();
            doc.Save(path);
        }
    }
}
