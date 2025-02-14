﻿using FastX.Models;
using FastX.Models.DTOs;
using Microsoft.AspNetCore.Mvc;

namespace FastX.Interfaces
{
    public interface IAmenityService
    {
        public Task<Amenity> AddAmenity(Amenity amenity);
        public Task<List<Amenity>> GetAmenityList();
        public Task<Amenity> GetAmenity(int id);
        public Task<Amenity> DeleteAmenity(int id);
        public Task<Amenity> ChangeAmenityNameAsync(int id, string name);
        //----------------------------
        public Task AddAmenityToBus(int busId, string amenityName);
        public  Task DeleteAmenityFromBus(int busId, string amenityName);
        public Task AddAmenitiesToBus(int busId, List<string> amenityNames);
        //public Task<List<string>> GetAmenityNamesByBusId(int busId);
        public Task<List<AmenityDTO>> GetBusAmenitiesAsync(int busId);




    }
}
