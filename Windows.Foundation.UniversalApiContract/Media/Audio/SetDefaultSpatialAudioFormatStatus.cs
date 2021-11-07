// Decompiled with JetBrains decompiler
// Type: Windows.Media.Audio.SetDefaultSpatialAudioFormatStatus
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Media.Audio
{
  /// <summary>Specifies the status of the SetDefaultSpatialAudioFormatResult, whether it failed (and why) or succeeded.</summary>
  [ContractVersion(typeof (UniversalApiContract), 458752)]
  public enum SetDefaultSpatialAudioFormatStatus
  {
    /// <summary>The call succeeded and the format was set.</summary>
    Succeeded,
    /// <summary>The caller doesn't have permission to change/set this spatial audio format.</summary>
    AccessDenied,
    /// <summary>There is no current license for this spatial audio format.</summary>
    LicenseExpired,
    /// <summary>This spatial audio format is licensed, but not for this endpoint.</summary>
    LicenseNotValidForAudioEndpoint,
    /// <summary>This audio endpoint doesn't support this format.</summary>
    NotSupportedOnAudioEndpoint,
    /// <summary>Something unexpected went wrong.</summary>
    UnknownError,
  }
}
