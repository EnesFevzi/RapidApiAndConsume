﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelProject.DataAccessLayer.Abstract
{
	public interface IGenericRepository<T> where T : class
	{
		void Add(T t);
		void Delete(T t);
		void Update(T t);
		List<T> GetList();
		T GetByID(int id);
	}
}
