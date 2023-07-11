using HotelProject.BusinessLayer.Abstract;
using HotelProject.DataAccessLayer.Abstract;
using HotelProject.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelProject.BusinessLayer.Concrete
{
    public class ContactManager : IContactService
    {
        private readonly IContactRepository _contactRepository;

        public ContactManager(IContactRepository contactRepository)
        {
            _contactRepository = contactRepository;
        }

        public void TAdd(Contact t)
        {
            _contactRepository.Add(t);
        }

        public void TDelete(Contact t)
        {
           _contactRepository.Delete(t);
        }

        public Contact TGetByID(int id)
        {
            return _contactRepository.GetByID(id);  
        }

        public List<Contact> TGetList()
        {
           return _contactRepository.GetList();
        }

        public void TUpdate(Contact t)
        {
            _contactRepository.Update(t);
        }
    }
}
