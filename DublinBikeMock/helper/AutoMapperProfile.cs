using AutoMapper;
using DublinBikeMock.Dto;
using DublinBikeMock.models;

namespace DublinBikeMock.helper;

public class AutoMapperProfile: Profile
{
    public AutoMapperProfile()
    {
        CreateMap<BikeStation, BikeStationDto>();
    }
    
}