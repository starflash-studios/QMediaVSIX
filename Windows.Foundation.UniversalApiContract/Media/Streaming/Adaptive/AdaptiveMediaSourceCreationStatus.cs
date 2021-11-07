// Decompiled with JetBrains decompiler
// Type: Windows.Media.Streaming.Adaptive.AdaptiveMediaSourceCreationStatus
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Media.Streaming.Adaptive
{
  /// <summary>Specifies the result of an attempt to create a AdaptiveMediaSource object.</summary>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public enum AdaptiveMediaSourceCreationStatus
  {
    /// <summary>The AdaptiveMediaSource object was successfully created.</summary>
    Success,
    /// <summary>The creation of the AdaptiveMediaSource object failed as the result of a failure in downloading the adaptive streaming manifest.</summary>
    ManifestDownloadFailure,
    /// <summary>The creation of the AdaptiveMediaSource object failed as the result of a failure in parsing the adaptive streaming manifest.</summary>
    ManifestParseFailure,
    /// <summary>The creation of the AdaptiveMediaSource object failed because the content of the adaptive streaming manifest is unsupported.</summary>
    UnsupportedManifestContentType,
    /// <summary>The creation of the AdaptiveMediaSource object failed because the version of the adaptive streaming manifest is unsupported.</summary>
    UnsupportedManifestVersion,
    /// <summary>The creation of the AdaptiveMediaSource object failed because the profile of the adaptive streaming manifest is unsupported.</summary>
    UnsupportedManifestProfile,
    /// <summary>The creation of the AdaptiveMediaSource object failed because of an unknown failure.</summary>
    UnknownFailure,
  }
}
