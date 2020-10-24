using FortnoxAPILibrary.Entities;
using System.Threading.Tasks;

// ReSharper disable UnusedMember.Global
namespace FortnoxAPILibrary.Connectors
{
    /// <remarks/>
    public interface ILockedPeriodConnector : IEntityConnector
	{
		LockedPeriodSearch Search { get; set; }

		Sort.Order? SortOrder { get; set; }
		Sort.By.LockedPeriod? SortBy { get; set; }

        LockedPeriod Get();

        Task<LockedPeriod> GetAsync();
    }
}
