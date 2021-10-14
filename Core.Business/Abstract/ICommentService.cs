using System;
using System.Collections.Generic;
using Core.Entity.Concrete;

namespace Core.Business.Abstract
{
    public interface ICommentService
    {
        void Add(Comment comment);
        void Delete(Comment comment);
        void Update(Comment comment);
        List<Comment> GetAll(int id);
        Comment GetById(int id);
    }
}
