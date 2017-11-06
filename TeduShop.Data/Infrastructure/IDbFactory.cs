using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeduShop.Data.Infrastructure
{
    // Giao tiếp để khởi tạo các đối tượng Entity
    // Không khởi tạo trực tiếp mà thông qua Factory
    public interface IDbFactory : IDisposable
    {
        TeduShopDbContext Init();
    }
}
