using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace BulkImageDownloader.Cli.ViewModels
{
    public struct BingApiResponseVM
	{
		[JsonPropertyName("images")]
		public IReadOnlyList<BingImages> Images { get; init; }
	}
}
