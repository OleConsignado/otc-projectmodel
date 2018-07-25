﻿using AutoMapper;
using Otc.ProjectModel.Core.Domain.Models;
using Otc.ProjectModel.WebApi.Dtos;

namespace Otc.ProjectModel.WebApi
{
    public static class Mappings
    {
        public static void Initialize()
        {
            Mapper.Initialize(c =>
            {
                //Get
                c.CreateMap<Client, ClientGet>();
                c.CreateMap<Address, AddClientPost.AddressPost>();

                //Post
                c.CreateMap<AddClientPost, Client>();//.ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.ClientId));
                c.CreateMap<AddClientPost.AddressPost, Address>();
                c.CreateMap<AddClientSubscriptionPost, Subscription>();
            });
        }
    }
}
