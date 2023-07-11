﻿using HotelProject.DataAccessLayer.Abstract;
using HotelProject.DataAccessLayer.Repository;
using HotelProject.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelProject.DataAccessLayer.Concrete.EntityFramework
{
    public class EfGuestRepository : GenericRepository<Guest>, IGuestRepository
    {
        public EfGuestRepository(TContext context) : base(context)
        {
        }
    }
}