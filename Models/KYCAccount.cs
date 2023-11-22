using System.ComponentModel.DataAnnotations;

namespace dotnet_test4.Models;
public class KYC
{
    [Key]
    public Guid UAccID { get; set; }
     
    [Required]
    public string? UAccUsername { get; set; }
    public string? UAccPassword { get; set; }
    
   
}