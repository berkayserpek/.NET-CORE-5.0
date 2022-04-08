using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Abstract
{
    public interface IUserMessageDAL : IGenericDAL<UserMessage>
    {
        public List<UserMessage> GetUserMessageWithUser();
    }
}
