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
    public class MessageCategoryManager : IMessageCategoryService
    {
        private readonly IMessageCategoryRepository _messageCategoryRepository;

        public MessageCategoryManager(IMessageCategoryRepository messageCategoryRepository)
        {
            _messageCategoryRepository = messageCategoryRepository;
        }

        public void TAdd(MessageCategory t)
        {
            _messageCategoryRepository.Add(t);
        }

        public void TDelete(MessageCategory t)
        {
            _messageCategoryRepository.Delete(t);
        }

        public MessageCategory TGetByID(int id)
        {
            return _messageCategoryRepository.GetByID(id);
        }

        public List<MessageCategory> TGetList()
        {
           return _messageCategoryRepository.GetList();
        }

        public void TUpdate(MessageCategory t)
        {
            _messageCategoryRepository.Update(t);
        }
    }
}
