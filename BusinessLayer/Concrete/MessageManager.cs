using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class MessageManager : IMessageService
    {
        IMessageDAL _messageDAL;

        public MessageManager(IMessageDAL messageDAL)
        {
            _messageDAL = messageDAL;
        }

        public void TAdd(Message t)
        {
            _messageDAL.Insert(t);
        }

        public void TDelete(Message t)
        {
            throw new NotImplementedException();
        }

        public Message TGetByID(int id)
        {
            throw new NotImplementedException();
        }

        public List<Message> TGetList()
        {
            throw new NotImplementedException();
        }

        public List<Message> TGetListByWhere(string p)
        {
            throw new NotImplementedException();
        }

        public void TUpdate(Message t)
        {
            throw new NotImplementedException();
        }
    }
}
