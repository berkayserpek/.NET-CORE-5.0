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
    public class SocialMediaManager : ISocialMedia
    {
        ISocialMediaDAL _socialMediaDAL;

        public SocialMediaManager(ISocialMediaDAL socialMediaDAL)
        {
            _socialMediaDAL = socialMediaDAL;
        }

        public void TAdd(SocialMedia t)
        {
            _socialMediaDAL.Insert(t);
        }

        public void TDelete(SocialMedia t)
        {
            _socialMediaDAL.Delete(t);
        }

        public SocialMedia TGetByID(int id)
        {
            return _socialMediaDAL.GetByID(id);
        }

        public List<SocialMedia> TGetList()
        {
            return _socialMediaDAL.GetList();
        }

        public List<SocialMedia> TGetListByWhere(string p)
        {
            throw new NotImplementedException();
        }

        public void TUpdate(SocialMedia t)
        {
            _socialMediaDAL.Update(t);
        }
    }
}
