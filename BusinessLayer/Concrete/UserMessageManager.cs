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
    public class UserMessageManager : IUserMessageService
    {
        IUserMessageDAL userMessageDAL;

        public UserMessageManager(IUserMessageDAL userMessageDAL)
        {
            this.userMessageDAL = userMessageDAL;
        }

        public List<UserMessage> GetUserMessageWithUserService()
        {
            return userMessageDAL.GetUserMessageWithUser();
        }

        public void TAdd(UserMessage t)
        {
            throw new NotImplementedException();
        }

        public void TDelete(UserMessage t)
        {
            throw new NotImplementedException();
        }

        public UserMessage TGetByID(int id)
        {
            throw new NotImplementedException();
        }

        public List<UserMessage> TGetList()
        {
            return userMessageDAL.GetList();
        }

        public List<UserMessage> TGetListByWhere(string p)
        {
            throw new NotImplementedException();
        }

        public void TUpdate(UserMessage t)
        {
            throw new NotImplementedException();
        }
    }
}
