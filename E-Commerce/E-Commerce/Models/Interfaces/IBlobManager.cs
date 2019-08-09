using Microsoft.Azure.Storage.Blob;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace E_Commerce.Models.Interfaces
{
    public interface IBlobManager
	{
        Task<CloudBlobContainer> GetContainer(string containerName);

        Task<CloudBlob> GetBlob(string imageName, string containerName);

        void UploadFile(CloudBlobContainer container, string fileName, string filePath);
	}
}
