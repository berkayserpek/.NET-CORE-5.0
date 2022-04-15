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
    public class AboutManager : IAboutService
    {
        IAboutDAL _aboutDAL;
        public AboutManager(IAboutDAL aboutDAL)
        {
            _aboutDAL = aboutDAL;
        }
        public List<About> TGetList()
        {
            return _aboutDAL.GetList();
        }

        public void TAdd(About t)
        {
            _aboutDAL.Insert(t);
        }

        public void TDelete(About t)
        {
            _aboutDAL.Delete(t);
        }

        public About TGetByID(int id)
        {
            return _aboutDAL.GetByID(id);
        }

        public void TUpdate(About t)
        {
            _aboutDAL.Update(t);
        }

        public List<About> TGetListByWhere(string p)
        {
            throw new NotImplementedException();
        }
    }
}
