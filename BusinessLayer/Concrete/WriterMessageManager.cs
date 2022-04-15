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
    public class WriterMessageManager : IWriterMessageService
    {
        IWriterMessageDAL _writerMessageDAL;

        public WriterMessageManager(IWriterMessageDAL writerMessageDAL)
        {
            _writerMessageDAL = writerMessageDAL;
        }

        public void TAdd(WriterMessage t)
        {
            throw new NotImplementedException();
        }

        public void TDelete(WriterMessage t)
        {
            throw new NotImplementedException();
        }

        public WriterMessage TGetByID(int id)
        {
            throw new NotImplementedException();
        }

        public List<WriterMessage> TGetList()
        {
            throw new NotImplementedException();
        }
        public List<WriterMessage> TGetListByWhere(string p)
        {
            return _writerMessageDAL.GetByWhere(x => x.Receiver == p);
        }
        public void TUpdate(WriterMessage t)
        {
            throw new NotImplementedException();
        }
    }
}
