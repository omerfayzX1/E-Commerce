using E_Commerce.Business.Concreate;
using E_Commerce.Data.Context;
using E_Commerce.Data.Models.Entities;
using E_CommerceDAL.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_CommerceDAL.Concreate
{
    public class CategoryDAL : GenericRepository<Category, E_CommerceContext>, ICategoryDAL
    {
       
    }
}
