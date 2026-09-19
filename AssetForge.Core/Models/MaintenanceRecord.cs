using System.ComponentModel.DataAnnotations;
namespace AssetForge.Core.Models;
public class MaintenanceRecord{public long Id{get;set;}public int AssetId{get;set;}public Asset? Asset{get;set;}[Required,MaxLength(160)]public string Issue{get;set;}="";[MaxLength(120)]public string? Supplier{get;set;}[MaxLength(30)]public string Status{get;set;}="Open";public decimal? Cost{get;set;}public DateTime OpenedUtc{get;set;}=DateTime.UtcNow;public DateTime? CompletedUtc{get;set;}[MaxLength(1000)]public string? Resolution{get;set;}[MaxLength(120)]public string LoggedBy{get;set;}="";}
public class Supplier{public int Id{get;set;}[Required,MaxLength(120)]public string Name{get;set;}="";[MaxLength(200)]public string? Email{get;set;}[MaxLength(60)]public string? Phone{get;set;}}
