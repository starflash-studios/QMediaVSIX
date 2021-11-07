// Decompiled with JetBrains decompiler
// Type: Windows.Storage.FileProperties.PropertyPrefetchOptions
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Storage.FileProperties
{
  /// <summary>Indicates a system-defined group of file properties.</summary>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Flags]
  public enum PropertyPrefetchOptions : uint
  {
    /// <summary>No specific, system-defined property group.</summary>
    None = 0,
    /// <summary>A group of music-related properties that can be access through a MusicProperties object.</summary>
    MusicProperties = 1,
    /// <summary>A group of video-related properties that can be access through a VideoProperties object.</summary>
    VideoProperties = 2,
    /// <summary>A group of image-related properties that can be access through a ImageProperties object.</summary>
    ImageProperties = 4,
    /// <summary>A group of document-related properties that can be access through a DocumentProperties object.</summary>
    DocumentProperties = 8,
    /// <summary>A group of basic properties that can be access through a BasicProperties object.</summary>
    BasicProperties = 16, // 0x00000010
  }
}
