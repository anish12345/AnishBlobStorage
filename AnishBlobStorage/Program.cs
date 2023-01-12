using Azure.Storage.Blobs;
using Azure.Storage.Blobs.Models;

string connectionString = "DefaultEndpointsProtocol=https;AccountName=anishstorage786;AccountKey=E0ShJ37KOKnzUF5p5ijvLKigF1Tm02OJPsKQ0UqA+ouiwPZ+LC0oMXt56Ky4Vg0dpaJdwiIA8UT++ASt4lT15Q==;EndpointSuffix=core.windows.net";
string containerName = "anishstorage78692";
string blobName = "script.sql";
string filePath = "C:\\scripts\\productTable.sql";
string fileDownloadPath = "C:\\downloadBlob\\productTable.sql";


// download blob

BlobClient blobClient = new BlobClient(connectionString, containerName, blobName);

await blobClient.DownloadToAsync(fileDownloadPath);

Console.WriteLine("The blob is downloaded");



////get list of blobs
//BlobContainerClient blobContainerClient = new BlobContainerClient(connectionString, containerName);

//await foreach (BlobItem blobItem in blobContainerClient.GetBlobsAsync())
//{
//    Console.WriteLine("The Blob Name is {0}", blobItem.Name);
//    Console.WriteLine("The Blob Size is {0}", blobItem.Properties.ContentLength);
//}




//// Upload file to container

//BlobContainerClient blobServiceClient = new BlobContainerClient(connectionString, containerName);

//BlobClient blobClient = blobServiceClient.GetBlobClient(blobName);
//await blobClient.UploadAsync(filePath, true);

//Console.WriteLine("Uploaded the blob");



// To create New container
//BlobServiceClient blobServiceClient = new BlobServiceClient(connectionString);

//Console.WriteLine("Creating the container");

//await blobServiceClient.CreateBlobContainerAsync(containerName,Azure.Storage.Blobs.Models.PublicAccessType.BlobContainer);

///*
//If you want to specify properties for the container

//await blobServiceClient.CreateBlobContainerAsync(containerName,Azure.Storage.Blobs.Models.PublicAccessType.Blob);
//*/
//Console.WriteLine("Container creation complete");
