// Decompiled with JetBrains decompiler
// Type: Windows.Media.Core.MediaDecoderStatus
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Media.Core
{
  /// <summary>Specifies the status of a media decoder when decoding a media item.</summary>
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  public enum MediaDecoderStatus
  {
    /// <summary>The encoding of the media item is fully supported by the decoder.</summary>
    FullySupported,
    /// <summary>The encoding subtype of the media item is not supported by the decoder.</summary>
    UnsupportedSubtype,
    /// <summary>The media item uses encoding properties that are not supported by the decoder.</summary>
    UnsupportedEncoderProperties,
    /// <summary>The media item can be decoded by the decoder, but with a degradation from the encoding.</summary>
    Degraded,
  }
}
