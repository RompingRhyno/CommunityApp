using System;
using Microsoft.AspNetCore.SignalR;
using Microsoft.EntityFrameworkCore;
using CommunityApp.Models;

namespace CommunityApp.Data;

public static class SeedData
{
    public static void Seed(this ModelBuilder modelBuilder) 
    {
        modelBuilder.Entity<Province>().HasData(
            GetProvinces()
        );
        modelBuilder.Entity<City>().HasData(
            GetCities()
        );
    }
    public static List<Province> GetProvinces() {
        List<Province> provinces = [
            new Province { ProvinceCode = "AB", ProvinceName = "Alberta" },
            new Province { ProvinceCode = "BC", ProvinceName = "British Columbia" },
            new Province { ProvinceCode = "MB", ProvinceName = "Manitoba" },
            new Province { ProvinceCode = "NB", ProvinceName = "New Brunswick" },
            new Province { ProvinceCode = "NL", ProvinceName = "Newfoundland and Labrador" },
            new Province { ProvinceCode = "NS", ProvinceName = "Nova Scotia" },
            new Province { ProvinceCode = "ON", ProvinceName = "Ontario" },
            new Province { ProvinceCode = "PE", ProvinceName = "Prince Edward Island" },
            new Province { ProvinceCode = "QC", ProvinceName = "Quebec" },
            new Province { ProvinceCode = "SK", ProvinceName = "Saskatchewan" },
            new Province { ProvinceCode = "NT", ProvinceName = "Northwest Territories" },
            new Province { ProvinceCode = "NU", ProvinceName = "Nunavut" },
            new Province { ProvinceCode = "YT", ProvinceName = "Yukon" }
        ];
        return provinces;
    }
            

    public static List<City> GetCities() {
        List<City> cities = new List<City>
        {
            new City { CityId = 1, CityName = "Calgary", Population = 1336000, ProvinceCode = "AB" },
            new City { CityId = 2, CityName = "Edmonton", Population = 981000, ProvinceCode = "AB" },
            new City { CityId = 3, CityName = "Red Deer", Population = 100418, ProvinceCode = "AB" },
            new City { CityId = 4, CityName = "Vancouver", Population = 2463431, ProvinceCode = "BC" },
            new City { CityId = 5, CityName = "Surrey", Population = 517887, ProvinceCode = "BC" },
            new City { CityId = 6, CityName = "Burnaby", Population = 232755, ProvinceCode = "BC" },
            new City { CityId = 7, CityName = "Richmond", Population = 198309, ProvinceCode = "BC" },
            new City { CityId = 8, CityName = "Winnipeg", Population = 749534, ProvinceCode = "MB" },
            new City { CityId = 9, CityName = "Brandon", Population = 48859, ProvinceCode = "MB" },
            new City { CityId = 10, CityName = "Thompson", Population = 13008, ProvinceCode = "MB" },
            new City { CityId = 11, CityName = "Saint John", Population = 67575, ProvinceCode = "NB" },
            new City { CityId = 12, CityName = "Moncton", Population = 144810, ProvinceCode = "NB" },
            new City { CityId = 13, CityName = "Fredericton", Population = 58206, ProvinceCode = "NB" },
            new City { CityId = 14, CityName = "Labrador City", Population = 9445, ProvinceCode = "NL" },
            new City { CityId = 15, CityName = "St. John's", Population = 108860, ProvinceCode = "NL" },
            new City { CityId = 16, CityName = "Corner Brook", Population = 19504, ProvinceCode = "NL" },
            new City { CityId = 17, CityName = "Halifax", Population = 403131, ProvinceCode = "NS" },
            new City { CityId = 18, CityName = "Sydney", Population = 31686, ProvinceCode = "NS" },
            new City { CityId = 19, CityName = "Truro", Population = 12349, ProvinceCode = "NS" },
            new City { CityId = 20, CityName = "Toronto", Population = 2731571, ProvinceCode = "ON" },
            new City { CityId = 21, CityName = "Ottawa", Population = 934243, ProvinceCode = "ON" },
            new City { CityId = 22, CityName = "Mississauga", Population = 721599, ProvinceCode = "ON" },
            new City { CityId = 23, CityName = "Charlettetown", Population = 36847, ProvinceCode = "PE" },
            new City { CityId = 24, CityName = "Souris", Population = 1279, ProvinceCode = "PE" },
            new City { CityId = 25, CityName = "Summerside", Population = 14857, ProvinceCode = "PE" },
            new City { CityId = 26, CityName = "Quebec City", Population = 531902, ProvinceCode = "QC" },
            new City { CityId = 27, CityName = "Montreal", Population = 1704694, ProvinceCode = "QC" },
            new City { CityId = 28, CityName = "Laval", Population = 422993, ProvinceCode = "QC" },
            new City { CityId = 29, CityName = "Saskatoon", Population = 246376, ProvinceCode = "SK" },
            new City { CityId = 30, CityName = "Regina", Population = 215106, ProvinceCode = "SK" },
            new City { CityId = 31, CityName = "Moose Jaw", Population = 33877, ProvinceCode = "SK" },
            new City { CityId = 32, CityName = "Yellowknife", Population = 19569, ProvinceCode = "NT" },
            new City { CityId = 33, CityName = "Inuvik", Population = 3495, ProvinceCode = "NT" },
            new City { CityId = 34, CityName = "Hay River", Population = 3461, ProvinceCode = "NT" },
            new City { CityId = 35, CityName = "Iqaluit", Population = 6695, ProvinceCode = "NU" },
            new City { CityId = 36, CityName = "Baker Lake", Population = 2058, ProvinceCode = "NU" },
            new City { CityId = 37, CityName = "Rankin Inlet", Population = 2825, ProvinceCode = "NU" },
            new City { CityId = 38, CityName = "Whitehorse", Population = 25085, ProvinceCode = "YT" },
            new City { CityId = 39, CityName = "Dawson City", Population = 1319, ProvinceCode = "YT" },
            new City { CityId = 40, CityName = "Watson Lake", Population = 790, ProvinceCode = "YT" }
        };
        return cities;
    }
}
