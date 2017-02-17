﻿using Project.DataLayer.DataAccess.Abstract;
using Project.DataLayer.Concrete.EntityFramework.Contexts;
using Project.Shared.DataTypes.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.DataLayer.Concrete.EntityFramework
{
    public class EfCategoryDal:EfEntitityRepositoryBase<Category,NortwindContext>,ICategoryDal
    {

    }
}
