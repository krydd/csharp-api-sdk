using FortnoxAPILibrary.Entities;
using System.Threading.Tasks;

// ReSharper disable UnusedMember.Global
namespace FortnoxAPILibrary.Connectors
{
    /// <remarks/>
    public interface ICompanySettingsConnector : IEntityConnector
	{
		CompanySettingsSearch Search { get; set; }

		Sort.Order? SortOrder { get; set; }
		Sort.By.CompanySettings? SortBy { get; set; }

		CompanySettings Get();

		Task<CompanySettings> GetAsync();
	}
}
