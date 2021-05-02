﻿using System.Collections.Generic;
using System.Threading.Tasks;
using BulkImageDownloader.Cli.ViewModels;

namespace BulkImageDownloader.Cli.Interfaces
{
	public interface IPexelService : IDownloadService
	{
		Task<List<ImageInfo>> GetCurratedImagesAsync(int count);
		bool InitiateConnection(string accessKey);
		Task<List<ImageInfo>> SearchPhotosByNameAsync(string name, int count);
	}
}
