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
    public class ToDoListManager : IToDoListService
    {
        IToDoListDAL toDoListDAL;

        public ToDoListManager(IToDoListDAL toDoListDAL)
        {
            this.toDoListDAL = toDoListDAL;
        }

        public void TAdd(ToDoList t)
        {
            throw new NotImplementedException();
        }

        public void TDelete(ToDoList t)
        {
            throw new NotImplementedException();
        }

        public ToDoList TGetByID(int id)
        {
            throw new NotImplementedException();
        }

        public List<ToDoList> TGetList()
        {
            return toDoListDAL.GetList();
        }

        public List<ToDoList> TGetListByWhere(string p)
        {
            throw new NotImplementedException();
        }

        public void TUpdate(ToDoList t)
        {
            throw new NotImplementedException();
        }
    }
}
