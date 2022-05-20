using System.ComponentModel.DataAnnotations;

namespace ApiOne.Data
{
    public class Application
    {
        [Key]
        public int ApplicationNum { get; set; }
        [Required]
        public DateTime ApplicationDate { get; set; }
        public string? BranchBank { get; set; }
        public string? BranchBankAddr { get; set; }
        public int CreditManagerId { get; set; }
        public string? FirstName { get; set; }
        public string? MiddleName { get; set; }
        public string? LastName { get; set; }
        public DateTime DateBirth { get; set; }
        public string? CityBirth { get; set; }
        public string? AddressBirth { get; set; }
        public string? AddressCurrent { get; set; }
        public string? Inn { get; set; }
        public string? Snils { get; set; }
        public string? PassportNum { get; set; }
        public int CreditType { get; set; }
        public decimal RequestedAmount { get; set; }
        public string? RequestedCurrency { get; set; }
        public decimal AnnualSalary { get; set; }
        public decimal MonthlySalary { get; set; }
        public string? CompanyName { get; set; }
        public string? Comment { get; set; }
        public bool ScoringStatus { get; set; } = false;
    }
}
