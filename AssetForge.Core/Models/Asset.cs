using System.ComponentModel.DataAnnotations;
namespace AssetForge.Core.Models;
public class Asset
{
 public int Id{get;set;}[MaxLength(30)]public string AssetTag{get;set;}="";[Required,MaxLength(120)]public string Name{get;set;}="";[MaxLength(120)]public string? Manufacturer{get;set;}[MaxLength(120)]public string? Model{get;set;}[MaxLength(120)]public string? SerialNumber{get;set;}[MaxLength(30)]public string Status{get;set;}="Available";public int CategoryId{get;set;}public AssetCategory? Category{get;set;}public int? LocationId{get;set;}public Location? Location{get;set;}public int? DepartmentId{get;set;}public Department? Department{get;set;}public decimal? PurchasePrice{get;set;}public DateOnly? PurchaseDate{get;set;}public DateOnly? WarrantyExpires{get;set;}[MaxLength(1000)]public string? Notes{get;set;}public DateTime CreatedUtc{get;set;}=DateTime.UtcNow;public DateTime UpdatedUtc{get;set;}=DateTime.UtcNow;
}
public class AssetCategory{public int Id{get;set;}[Required,MaxLength(80)]public string Name{get;set;}="";public ICollection<Asset> Assets{get;set;}=[];}
public class Location{public int Id{get;set;}[Required,MaxLength(100)]public string Name{get;set;}="";public ICollection<Asset> Assets{get;set;}=[];}
public class Department{public int Id{get;set;}[Required,MaxLength(100)]public string Name{get;set;}="";public ICollection<Asset> Assets{get;set;}=[];}
public class AuditEvent{public long Id{get;set;}public int? AssetId{get;set;}public Asset? Asset{get;set;}[MaxLength(40)]public string Action{get;set;}="";[MaxLength(1000)]public string Details{get;set;}="";[MaxLength(120)]public string PerformedBy{get;set;}="";public DateTime OccurredUtc{get;set;}=DateTime.UtcNow;}
