﻿using System.Threading.Tasks;
using BulkImageDownloader.Cli.Helper.ViewModels;
using Refit;

namespace BulkImageDownloader.Cli.Interfaces
{
	public interface IBingApi
	{
		[Get("/{urlPostFix}")]
		public Task<BingApiResponseVM> GetResponseAsync(string urlPostFix);
	}
}