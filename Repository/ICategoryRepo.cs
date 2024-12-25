using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{

    // patteren/ Template  it is  useful 
    public interface ICategoryRepo
    {
        List<Category> GetAll();
        Category GetById(int id);

        void Create(Category category);

        void Update(Category category);

        void Delete(int id);

    }

    public interface IProduct
    {
        List<Category> GetAll();
        Category GetById(int id);

        void Create(Category category);

        void Update(Category category);

        void Delete(int id);

    }
}
