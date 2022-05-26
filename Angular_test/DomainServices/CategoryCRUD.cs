using Angular_test.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Angular_test.DomainServices
{
    public class CategoryCRUD : ICategoryCRUD
    {
        private readonly AppDbContext context;

        public CategoryCRUD(AppDbContext context)
        {
            this.context = context;
        }

        public Category Add(CategoryModel model)
        {
            var category = new Category
            {
                Title = model.Title,
                Description = model.Description,
                CreatedOn = DateTime.Now,
                ModifiedOn = DateTime.Now
            };
            context.Categories.Add(category);
            context.SaveChanges();
            return category;
        }

        public void Delete(int id)
        {
            var category = GetById(id); 
            context.Categories.Remove(category);
            context.SaveChanges();
        }

        public List<Category> GetAll()
        {
            return context.Categories.ToList();
        }

        public Category GetById(int id)
        {
            return context.Categories.Find(id);    
        }

        public Category Update(CategoryModel model)
        {
            var category = context.Categories.Find(model.Id);
            category.Title = model.Title;
            category.Description = model.Description;
            category.ModifiedOn = DateTime.Now;
            context.Categories.Update(category);
            context.SaveChanges();
            return category;
        }
    }
}
