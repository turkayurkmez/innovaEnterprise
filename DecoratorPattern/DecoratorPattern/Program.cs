// See https://aka.ms/new-console-template for more information
using System.IO.Compression;
using System.Net.Sockets;
using System.Security.Cryptography;

Console.WriteLine("Hello, World!");

Stream memory = new MemoryStream();
Stream file = new FileStream("file.txt", FileMode.Open);
//var socket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
//Stream network = new NetworkStream(socket);

CryptoStream cryptoStream = new CryptoStream(file, new SHA256Managed(), CryptoStreamMode.Write);
GZipStream gZip = new GZipStream(cryptoStream, CompressionMode.Compress);
