using Azure.Storage.Blobs;
using System;
using System.IO;
using System.Threading.Tasks;

namespace WebAppComDB.Infra.Service
{
    public class BlobService : IBlobService
    {
        private readonly BlobServiceClient _blobserviceClient;
        private const string _containerName = "images";
        public BlobService(string connectionString)
        {
            _blobserviceClient = new BlobServiceClient(connectionString);
        }


        public async Task<string> UploadAsync(Stream stream)
        {
           var container = _blobserviceClient.GetBlobContainerClient(_containerName);

            await container.CreateIfNotExistsAsync();
            await container.SetAccessPolicyAsync(Azure.Storage.Blobs.Models.PublicAccessType.BlobContainer);
            var blobCliente = container.GetBlobClient($"{Guid.NewGuid()}.jpg");

            await blobCliente.UploadAsync(stream);
            return blobCliente.Uri.ToString();
        }

        public async Task DeleteAsync(string blobName)
        {
            var container = _blobserviceClient.GetBlobContainerClient(_containerName);

            var blobCliente = container.GetBlobClient(blobName);
            await blobCliente.DeleteIfExistsAsync();
        }





    }
}
