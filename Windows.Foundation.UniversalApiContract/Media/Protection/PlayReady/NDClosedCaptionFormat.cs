// Decompiled with JetBrains decompiler
// Type: Windows.Media.Protection.PlayReady.NDClosedCaptionFormat
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Media.Protection.PlayReady
{
  /// <summary>Indicates the type of format used for closed captions.</summary>
  /// <deprecated type="deprecate">NDClosedCaptionFormat is deprecated and might not work on all platforms. For more info, see MSDN.</deprecated>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Deprecated("NDClosedCaptionFormat is deprecated and might not work on all platforms. For more info, see MSDN.", DeprecationType.Deprecate, 196608, "Windows.Foundation.UniversalApiContract")]
  public enum NDClosedCaptionFormat
  {
    /// <summary>ATSC digital television closed captions.</summary>
    ATSC,
    /// <summary>SCTE 20 MPEG2 closed captions.</summary>
    SCTE20,
    /// <summary>Invalid format.</summary>
    Unknown,
  }
}
