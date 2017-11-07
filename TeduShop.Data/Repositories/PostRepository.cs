using System.Collections.Generic;
using System.Linq;
using TeduShop.Data.Infrastructure;
using TeduShop.Model.Models;

namespace TeduShop.Data.Repositories
{
    public interface IPostRepository : IRepository<Post>
    {
        IEnumerable<Post> GetAllByTag(string tag, int pageIndex, int pageSize, out int totalRow);
    }

    public class PostRepository : RepositoryBase<Post>, IPostRepository
    {
        public PostRepository(IDbFactory dbFactory) : base(dbFactory)
        {
        }
        public IEnumerable<Post> GetAllByTag(string tag, int pageIndex, int pageSize, out int totalRow)
        {
            var query = from p in DbContext.Posts
                        join pt in DbContext.PostTags
                        on p.ID equals pt.PostID
                        where pt.TagID == tag && p.Status
                        orderby p.CreatedDate descending
                        select p;

            totalRow = query.Count();

            // pageIndex = 1, pageSize = 20 => Skip((1-1)*20).Take(20) => Lấy từ vị trí 0 lấy 20 bảng ghi
            // pageIndex = 2, pageSize = 20 => Skip(20).Take(20) => Lấy từ vị trí 20 lấy tiếp 20 bảng ghi
            // pageIndex = 3, pageSize = 20 => Skip(40).Take(20) => Lấy từ vị trí 40 lấy tiếp 20 bảng ghi
            query = query.Skip((pageIndex - 1) * pageSize).Take(pageSize);

            return query;
        }
    }
}