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
    public class HighlightManager : IHighlightService
    {
        IHighlightDal _highlightDal;

        public HighlightManager(IHighlightDal highlightDal)
        {
            _highlightDal = highlightDal;
        }

        public void TAdd(Highlight t)
        {
            throw new NotImplementedException();
        }

        public void TDelete(Highlight t)
        {
            throw new NotImplementedException();
        }

        public Highlight TGetByID(int id)
        {
            throw new NotImplementedException();
        }

        public List<Highlight> TGetList()
        {
            return _highlightDal.GetList();
        }

        public void TUpdate(Highlight t)
        {
            throw new NotImplementedException();
        }
    }
}
