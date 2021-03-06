using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public interface IContentService
    {
        List<Content> GetList();

        List<Content> GetListByHeadingID(int id);

        List<Content> GetListByWriterID(int id);
        void ContentAdd(Content p);

        Content GetByID(int id);

        void ContentDelete(Content p);

        void ContentUpdate(Content p);
    }
}
