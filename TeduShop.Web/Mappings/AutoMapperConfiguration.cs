using AutoMapper;
using TeduShop.Model.Models;
using TeduShop.Web.Models;

namespace TeduShop.Web.Mappings
{
    public class AutoMapperConfiguration
    {
        public static void Configure()
        {
            Mapper.Initialize(cfg => cfg.CreateMap<Post, PostViewModel>());
            Mapper.Initialize(cfg => cfg.CreateMap<Tag, TagViewModel>());
            Mapper.Initialize(cfg => cfg.CreateMap<PostTag, PostTagViewModel>());

            Mapper.Initialize(cfg => cfg.CreateMap<Product, ProductViewModel>());
            Mapper.Initialize(cfg => cfg.CreateMap<ProductCategory, ProductCategoryViewModel>());
        }
    }
}