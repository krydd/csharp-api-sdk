using FortnoxAPILibrary;
using FortnoxAPILibrary.Entities;
// ReSharper disable UnusedMember.Global
namespace FortnoxAPILibrary.Connectors
{
    /// <remarks/>
    public interface IAssetFileConnectionConnector : IConnector
	{
		Sort.Order? SortOrder { get; set; }
		Sort.By.AssetFileConnection? SortBy { get; set; }
		Filter.AssetFileConnection? FilterBy { get; set; }

		string AssetId { get; set; }

        AssetFileConnection Create(AssetFileConnection assetFileConnection);
		AssetFileConnection Get(string id);
		void Delete(string id);
		EntityCollection<AssetFileConnection> Find();
	}
}
