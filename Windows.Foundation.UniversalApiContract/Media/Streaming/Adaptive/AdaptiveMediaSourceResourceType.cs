// Decompiled with JetBrains decompiler
// Type: Windows.Media.Streaming.Adaptive.AdaptiveMediaSourceResourceType
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Media.Streaming.Adaptive
{
  /// <summary>Specifies the type of an adaptive media resource.</summary>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public enum AdaptiveMediaSourceResourceType
  {
    /// <summary>The resource is an adaptive streaming manifest.</summary>
    Manifest,
    /// <summary>The resource is an initialization segment.</summary>
    InitializationSegment,
    /// <summary>The resource is a media segment.</summary>
    MediaSegment,
    /// <summary>The resource is an encryption key.</summary>
    Key,
    /// <summary>The resource is a cryptographic initialization vector.</summary>
    InitializationVector,
    /// <summary>The resource is a media segment index.</summary>
    [ContractVersion("Windows.Foundation.UniversalApiContract", 458752)] MediaSegmentIndex,
  }
}
