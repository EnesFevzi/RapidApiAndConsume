using HotelProject.DataAccessLayer.Abstract;
using HotelProject.DataAccessLayer.Repository;
using HotelProject.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelProject.DataAccessLayer.Concrete.EntityFramework
{
    internal class EfSendMessageRepository : GenericRepository<SendMessage>, ISendMessageRepository
    {
        public EfSendMessageRepository(TContext context) : base(context)
        {

        }
        public int GetSendMessageCount()
        {
            var context = new TContext();
            return context.SendMessages.Count();
        }
    }
}
