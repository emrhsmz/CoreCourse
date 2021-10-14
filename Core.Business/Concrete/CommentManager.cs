using System;
using System.Collections.Generic;
using Core.Business.Abstract;
using Core.DataAccess.Abstract;
using Core.Entity.Concrete;

namespace Core.Business.Concrete
{
    public class CommentManager:ICommentService
    {
        ICommentDal _commentDal;

        public CommentManager(ICommentDal commentDal)
        {
            _commentDal = commentDal;
        }

        public void Add(Comment comment)
        {
            _commentDal.Add(comment);
        }

        public void Delete(Comment comment)
        {
            _commentDal.Delete(comment);
        }

        public List<Comment> GetAll(int id)
        {
            return _commentDal.GetAll(x => x.BlogId == id);
        }

        public Comment GetById(int id)
        {
            return _commentDal.GetById(x => x.Id == id);
        }

        public void Update(Comment comment)
        {
            _commentDal.Update(comment);
        }
    }
}
