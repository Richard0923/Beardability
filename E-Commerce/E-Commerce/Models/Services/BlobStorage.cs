using E_Commerce.Models.Interfaces;
using Microsoft.Azure.Storage;
using Microsoft.Azure.Storage.Blob;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace E_Commerce.Models.Services
{
    public class BlobStorage : IBlobManager
    {
        public IConfiguration Configuration { get; }
        public CloudStorageAccount CloudStorage { get; set; }
        public CloudBlobClient CloudBlob { get; set; }
        
        public BlobStorage(IConfiguration configuration)
        {
            Configuration = configuration;
            CloudStorage = CloudStorageAccount.Parse(Configuration["AzureBlobConnString"]);
            CloudBlob = CloudStorage.CreateCloudBlobClient();
        }

        public async Task<CloudBlob> GetBlob(string imageName, string containerName)
        {
            var container = await GetContainer(containerName);
            CloudBlob blob = container.GetBlobReference(imageName);

            return blob;
        }

        public async Task<CloudBlobContainer> GetContainer(string containerName)
        {
            CloudBlobContainer container = CloudBlob.GetContainerReference(containerName);
            await container.CreateIfNotExistsAsync();
            await container.SetPermissionsAsync(new BlobContainerPermissions { PublicAccess = BlobContainerPublicAccessType.Blob });

            return container;
        }

        public void UploadFile(CloudBlobContainer container, string fileName, string filePath)
        {
            CloudBlockBlob blob = container.GetBlockBlobReference(fileName);
            blob.UploadFromFileAsync(filePath);
        }
    }
}
