using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeduShop.Data.Infrastructure
{
    public class UnitOfWork : IUnitOfWork
    {
        private TeduShopDbContext dbContext;
        private readonly IDbFactory dbFactory;
        public UnitOfWork(IDbFactory dbFactory)
        {
            this.dbFactory = dbFactory;
        }
        public TeduShopDbContext DbContext
        {
            get { return dbContext ?? (dbContext = new TeduShopDbContext()); }
        }
        public void Commit()
        {
            DbContext.SaveChanges();
        }
    }
}
