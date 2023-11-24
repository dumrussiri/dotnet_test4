using System.ComponentModel.DataAnnotations;

namespace dotnet_test4.Models;
public class KYC
{
    [Key]
    public Guid UAccID { get; set; }
     
    [Required]
    public string? UAccUsername { get; set; }

    public string? UAccPhoneNumber { get; set; }

    public byte[]? UAccPassword {get; set;} 
   public string GetPasswordAsHex()
    {
        if (UAccPassword != null)
        {
            return BitConverter.ToString(UAccPassword).Replace("-", "");
        }
        return string.Empty;
    }

    // Method to convert byte array to Base64 string
    public string GetPasswordAsBase64()
    {
        if (UAccPassword != null)
        {
            return Convert.ToBase64String(UAccPassword);
        }
        return string.Empty;
    }
}