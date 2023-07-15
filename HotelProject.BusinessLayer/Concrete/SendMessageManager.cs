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
    public class SendMessageManager : ISendMessageService
    {
        private readonly ISendMessageRepository _sendMessageRepository;

        public SendMessageManager(ISendMessageRepository sendMessageRepository)
        {
            _sendMessageRepository = sendMessageRepository;
        }

        public void TAdd(SendMessage t)
        {
            _sendMessageRepository.Add(t);
        }

        public void TDelete(SendMessage t)
        {
                _sendMessageRepository.Delete(t);
        }

        public SendMessage TGetByID(int id)
        {
           return _sendMessageRepository.GetByID(id);   
        }

        public List<SendMessage> TGetList()
        {
            return _sendMessageRepository.GetList();
        }

        public int TGetSendMessageCount()
        {
            return _sendMessageRepository.GetSendMessageCount();
        }

        public void TUpdate(SendMessage t)
        {
            _sendMessageRepository.Update(t);
        }
    }
}
