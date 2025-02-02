using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CommunityApp.Models;

public class City
{
    [Key]
    [Display(Name = "ID")]
    public int CityId { get; set; }
    [Required]
    [Display(Name = "City")]
    public string? CityName { get; set; }
    public int Population { get; set; }
    public string? ProvinceCode { get; set; }
    [ForeignKey("ProvinceCode")]
    public Province? Province { get; set; }
}
