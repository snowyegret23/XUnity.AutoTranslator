﻿using System.IO;

namespace XUnity.ResourceRedirector
{
   /// <summary>
   /// Class representing the parameters of the load call.
   /// </summary>
   public class AssetBundleLoadingParameters
   {
      internal AssetBundleLoadingParameters( byte[] data, string path, uint crc, ulong offset, Stream stream, uint managedReadBufferSize, AssetBundleLoadType loadType )
      {
         Binary = data;
         Path = path;
         Crc = crc;
         Offset = offset;
         Stream = stream;
         ManagedReadBufferSize = managedReadBufferSize;
         LoadType = loadType;
      }

      /// <summary>
      /// Gets or sets the loaded path. Only relevant for 'LoadFromFile'.
      /// </summary>
      public string Path { get; set; }

      /// <summary>
      /// Gets or sets the crc. Only relevant for 'LoadFromFile' and 'LoadFromMemory'.
      /// </summary>
      public uint Crc { get; set; }

      /// <summary>
      /// Gets or sets the offset. Only relevant for 'LoadFromFile'.
      /// </summary>
      public ulong Offset { get; set; }

      /// <summary>
      /// Gets or sets the stream. Only relevant for 'LoadFromStream'.
      /// </summary>
      public Stream Stream { get; set; }

      /// <summary>
      /// Gets or sets the managed read buffer size. Only relevant for 'LoadFromStream'.
      /// </summary>
      public uint ManagedReadBufferSize { get; }

      /// <summary>
      /// Gets or sets the binary data. Only relevant for 'LoadFromMemory'.
      /// </summary>
      public byte[] Binary { get; set; }

      /// <summary>
      /// Gets the type of call that is loading this asset bundle.
      /// </summary>
      public AssetBundleLoadType LoadType { get; }
   }
}
