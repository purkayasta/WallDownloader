using System.Text.Json.Serialization;

namespace BulkImageDownloader.Cli.ViewModels
{
    public struct BingImages
	{
        public BingImages(string url, string name)
        {
            Url = url;
            Name = name;
        }
        [JsonPropertyName("url")]
		public string Url { get; init; }

		[JsonPropertyName("title")]
		public string Name { get; init; }
	}
}
