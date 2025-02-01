using EF___Homework.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF___Homework.Service.Interfaces
{
    public interface IColorService
    {
        void Create(Color color);
        void Delete(int id);
        void Update(int id, Color color);
        Brand GetById(int id);
        List<Brand> GetAll();
    }
}
