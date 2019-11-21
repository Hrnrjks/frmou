using frmou.Data.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace frmou.Data
{
    public interface IPost
    {
        Post GetById(int id);
        IEnumerable<IPost> GetAll();
        IEnumerable<IPost> GetFilteredPosts(string searchQuery);

        Task Add(IPost post);
        Task Delete(int id);
        Task EditPostContent(int id, string newContent);
    }
}
