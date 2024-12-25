using AutoMapper;
using DAL;
using Model;
using Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAL
{
    public class CategoryBL : ICategoryBL
    {
        // refer to repo

        ICategoryRepo _CategoryRepo;

        public CategoryBL(ICategoryRepo categoryRepo)
        {
            _CategoryRepo = categoryRepo;
        }   

        public void Create(CategoryViewModel category)
        {
            /*_CategoryRepo.Create(category);*/

            Category cat = Mapper.Map<Category>(category);
            _CategoryRepo.Create(cat);
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public List<CategoryViewModel> GetAll()
        {
          /*  return _CategoryRepo.GetAll();*/  // it is directly send me Category i want categoryViewModel

            var Categories= _CategoryRepo.GetAll();
            return Mapper.Map<List<CategoryViewModel>>(Categories); 

            // List<Category>  => List<CategoryView Model>

        }

        public Category GetById(int id)
        {
            throw new NotImplementedException();
        }

        public void Update(Category category)
        {
            throw new NotImplementedException();
        }

        public void Update(CategoryViewModel category)
        {
            throw new NotImplementedException();
        }

        CategoryViewModel ICategoryBL.GetById(int id)
        {
            throw new NotImplementedException();
        }
    }
}
