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
    public class AnnouncementManager : IAnnouncementService
    {
        IAnnouncementDAL announcementDAL;

        public AnnouncementManager(IAnnouncementDAL announcementDAL)
        {
            this.announcementDAL = announcementDAL;
        }

        public void TAdd(Announcement t)
        {
            throw new NotImplementedException();
        }

        public void TDelete(Announcement t)
        {
            throw new NotImplementedException();
        }

        public Announcement TGetByID(int id)
        {
            return announcementDAL.GetByID(id);
        }

        public List<Announcement> TGetList()
        {
            return announcementDAL.GetList();
        }

        public List<Announcement> TGetListByWhere(string p)
        {
            throw new NotImplementedException();
        }

        public void TUpdate(Announcement t)
        {
            throw new NotImplementedException();
        }
    }
}
