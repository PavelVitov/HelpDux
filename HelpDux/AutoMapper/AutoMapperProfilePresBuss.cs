using AutoMapper;
using BusinessLayer.DTOs;
using DataLayer.Models;
using System.Linq;
using WebLayer_HelpDux.Models.Review;
using WebLayer_HelpDux.Models.User;
using WebLayer_HelpDux.Models.Website;

namespace WebLayer_HelpDux.AutoMapper
{
    public class AutoMapperProfilePresBuss : Profile
    {
        public AutoMapperProfilePresBuss()
        {
            CreateMap<UserDTO, UserMVC>()
                .ForMember(dest => dest.UserId, opt => opt.MapFrom(src => src.UserId))
                .ForMember(dest => dest.Username, opt => opt.MapFrom(src => src.Username))
                .ForMember(dest => dest.Email, opt => opt.MapFrom(src => src.Email))
                .ForMember(dest => dest.Password, opt => opt.MapFrom(src => src.Password))
                .ForMember(dest => dest.PictureUrl, opt => opt.MapFrom(src => src.PictureUrl))
                .ForMember(dest => dest.Roles, opt => opt.MapFrom(src => src.Roles))
                .ForMember(dest => dest.Reviews, opt => opt.MapFrom(src => src.Reviews.Select(r => new ReviewMVC
                {
                    ReviewId = r.ReviewId,
                    Comment = r.Comment,
                    Rating = r.Rating,
                    WebsiteId = r.WebsiteId,
                    WebsiteName = r.WebsiteName,
                    UserId = r.UserId,
                    Username = r.Username,
                    CreatedAt = r.CreatedAt,
                    UpdatedAt = r.UpdatedAt
                })));

            CreateMap<WebsiteDTO, WebsiteMVC>()
                .ForMember(dest => dest.WebsiteId, opt => opt.MapFrom(src => src.WebsiteId))
                .ForMember(dest => dest.Name, opt => opt.MapFrom(src => src.Name))
                .ForMember(dest => dest.Url, opt => opt.MapFrom(src => src.Url))
                .ForMember(dest => dest.Description, opt => opt.MapFrom(src => src.Description))
                .ForMember(dest => dest.Tag, opt => opt.MapFrom(src => src.Tag))
                .ForMember(dest => dest.CreatedAt, opt => opt.MapFrom(src => src.CreatedAt))
                .ForMember(dest => dest.UpdatedAt, opt => opt.MapFrom(src => src.UpdatedAt))
                .ForMember(dest => dest.IsActive, opt => opt.MapFrom(src => src.IsActive))
                .ForMember(dest => dest.ImageUrl, opt => opt.MapFrom(src => src.ImageUrl))
                .ForMember(dest => dest.Reviews, opt => opt.MapFrom(src => src.Reviews.Select(r => new ReviewMVC
                {
                    ReviewId = r.ReviewId,
                    Comment = r.Comment,
                    Rating = r.Rating,
                    WebsiteId = r.WebsiteId,
                    WebsiteName = r.WebsiteName,
                    UserId = r.UserId,
                    Username = r.Username,
                    CreatedAt = r.CreatedAt,
                    UpdatedAt = r.UpdatedAt
                })));

            CreateMap<ReviewDTO, ReviewMVC>()
                .ForMember(dest => dest.WebsiteName, opt => opt.MapFrom(src => src.WebsiteName))
                .ForMember(dest => dest.Username, opt => opt.MapFrom(src => src.Username))
                .ForMember(dest => dest.ReviewId, opt => opt.MapFrom(src => src.ReviewId))
                .ForMember(dest => dest.Comment, opt => opt.MapFrom(src => src.Comment))
                .ForMember(dest => dest.Rating, opt => opt.MapFrom(src => src.Rating))
                .ForMember(dest => dest.CreatedAt, opt => opt.MapFrom(src => src.CreatedAt))
                .ForMember(dest => dest.UpdatedAt, opt => opt.MapFrom(src => src.UpdatedAt))
                .ForMember(dest => dest.WebsiteId, opt => opt.MapFrom(src => src.WebsiteId))
                .ForMember(dest => dest.UserId, opt => opt.MapFrom(src => src.UserId));




            CreateMap<UserMVC, UserDTO>()
                .ForMember(dest => dest.UserId, opt => opt.MapFrom(src => src.UserId))
                .ForMember(dest => dest.Username, opt => opt.MapFrom(src => src.Username))
                .ForMember(dest => dest.Email, opt => opt.MapFrom(src => src.Email))
                .ForMember(dest => dest.Password, opt => opt.MapFrom(src => src.Password))
                .ForMember(dest => dest.PictureUrl, opt => opt.MapFrom(src => src.PictureUrl))
                .ForMember(dest => dest.Roles, opt => opt.MapFrom(src => src.Roles))
                .ForMember(dest => dest.Reviews, opt => opt.MapFrom(src => src.Reviews.Select(r => new ReviewDTO
                {
                    ReviewId = r.ReviewId,
                    Comment = r.Comment,
                    Rating = r.Rating,
                    WebsiteId = r.WebsiteId,
                    WebsiteName = r.WebsiteName,
                    UserId = r.UserId,
                    Username = r.Username,
                    CreatedAt = r.CreatedAt,
                    UpdatedAt = r.UpdatedAt
                })));

            CreateMap<WebsiteMVC, WebsiteDTO>()
                .ForMember(dest => dest.WebsiteId, opt => opt.MapFrom(src => src.WebsiteId))
                .ForMember(dest => dest.Name, opt => opt.MapFrom(src => src.Name))
                .ForMember(dest => dest.Url, opt => opt.MapFrom(src => src.Url))
                .ForMember(dest => dest.Description, opt => opt.MapFrom(src => src.Description))
                .ForMember(dest => dest.Tag, opt => opt.MapFrom(src => src.Tag))
                .ForMember(dest => dest.CreatedAt, opt => opt.MapFrom(src => src.CreatedAt))
                .ForMember(dest => dest.UpdatedAt, opt => opt.MapFrom(src => src.UpdatedAt))
                .ForMember(dest => dest.IsActive, opt => opt.MapFrom(src => src.IsActive))
                .ForMember(dest => dest.ImageUrl, opt => opt.MapFrom(src => src.ImageUrl))
                .ForMember(dest => dest.Reviews, opt => opt.MapFrom(src => src.Reviews.Select(r => new ReviewDTO
                {
                    ReviewId = r.ReviewId,
                    Comment = r.Comment,
                    Rating = r.Rating,
                    WebsiteId = r.WebsiteId,
                    WebsiteName = r.WebsiteName,
                    UserId = r.UserId,
                    Username = r.Username,
                    CreatedAt = r.CreatedAt,
                    UpdatedAt = r.UpdatedAt
                })));

            CreateMap<ReviewMVC, ReviewDTO>()
                .ForMember(dest => dest.WebsiteId, opt => opt.MapFrom(src => src.WebsiteId))
                .ForMember(dest => dest.UserId, opt => opt.MapFrom(src => src.UserId))
                .ForMember(dest => dest.ReviewId, opt => opt.MapFrom(src => src.ReviewId))
                .ForMember(dest => dest.Comment, opt => opt.MapFrom(src => src.Comment))
                .ForMember(dest => dest.Rating, opt => opt.MapFrom(src => src.Rating))
                .ForMember(dest => dest.CreatedAt, opt => opt.MapFrom(src => src.CreatedAt))
                .ForMember(dest => dest.UpdatedAt, opt => opt.MapFrom(src => src.UpdatedAt))
                .ForMember(dest => dest.WebsiteName, opt => opt.MapFrom(src => src.WebsiteName))
                .ForMember(dest => dest.Username, opt => opt.MapFrom(src => src.Username));
        }

    }
}
