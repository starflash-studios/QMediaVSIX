// Decompiled with JetBrains decompiler
// Type: Windows.Media.Core.MediaStreamSourceClosedReason
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Media.Core
{
  /// <summary>Specifies the reason why a MediaStreamSource was closed.</summary>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public enum MediaStreamSourceClosedReason
  {
    /// <summary>No error has occurred.</summary>
    Done,
    /// <summary>An unspecified error has occurred.</summary>
    UnknownError,
    /// <summary>The app reported an error by calling the NotifyError method on the MediaStreamSource.</summary>
    AppReportedError,
    /// <summary>Components needed to implement the protection system are missing.</summary>
    UnsupportedProtectionSystem,
    /// <summary>A failure occurred while initializing the protection system</summary>
    ProtectionSystemFailure,
    /// <summary>One or more media streams use an encoding format which cannot be handled by the media pipeline.</summary>
    UnsupportedEncodingFormat,
    /// <summary>The MediaStreamSource object does not have an event handler for the SampleRequested event.</summary>
    MissingSampleRequestedEventHandler,
  }
}
