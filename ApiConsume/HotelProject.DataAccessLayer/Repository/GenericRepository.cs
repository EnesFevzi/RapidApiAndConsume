using HotelProject.DataAccessLayer.Abstract;
using HotelProject.DataAccessLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelProject.DataAccessLayer.Repository
{
	public class GenericRepository<T> : IGenericRepository<T> where T : class
	{
		private readonly TContext _context;

		public GenericRepository(TContext context)
		{
			_context = context;
		}

		public void Add(T t)
		{
			_context.Add(t);
			_context.SaveChanges();
		}

		public void Delete(T t)
		{
			_context.Remove(t);
			_context.SaveChanges();
		}

		public T GetByID(int id)
		{
			return _context.Set<T>().Find(id);
		}

		public List<T> GetList()
		{
			return _context.Set<T>().ToList();
		}

		public void Update(T t)
		{
			_context.Update(t);
			_context.SaveChanges();
		}
	}
}
