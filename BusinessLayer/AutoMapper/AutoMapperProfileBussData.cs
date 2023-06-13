using AutoMapper;
using BusinessLayer.DTOs;
using DataLayer.Models;
using Microsoft.EntityFrameworkCore.Query.Internal;
using System;
using System.Linq;

namespace BusinessLayer.AutoMapper
{
    public class AutoMapperProfileBussData : Profile
    {
        public AutoMapperProfileBussData()
        {
            CreateMap<User, UserDTO>()
                .ForMember(dest => dest.Reviews, opt => opt.MapFrom(src => src.Reviews));
            CreateMap<Website, WebsiteDTO>()
                .ForMember(dest => dest.Reviews, opt => opt.MapFrom(src => src.Reviews.Select(r => new ReviewDTO { ReviewId = r.ReviewId, Rating = r.Rating, CreatedAt = r.CreatedAt, UpdatedAt = r.UpdatedAt, Username = r.User.Username })));           
            CreateMap<Review, ReviewDTO>()
                .ForMember(dest => dest.WebsiteName, opt => opt.MapFrom(src => src.Website.Name))
                .ForMember(dest => dest.Username, opt => opt.MapFrom(src => src.User.Username));

            CreateMap<UserDTO, User>()
                .ForMember(dest => dest.Reviews, opt => opt.MapFrom(src => src.Reviews));
            CreateMap<WebsiteDTO, Website>()
                .ForMember(dest => dest.Reviews, opt => opt.MapFrom(src => src.Reviews.Select(r => new Review { ReviewId = r.ReviewId, Rating = r.Rating, CreatedAt = r.CreatedAt, UpdatedAt = r.UpdatedAt, UserId = r.UserId })));
            CreateMap<ReviewDTO, Review>()
                .ForPath(dest => dest.User.Username, opt => opt.MapFrom(src => src.Username));

        }
    }
}
