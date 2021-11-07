// Decompiled with JetBrains decompiler
// Type: Windows.Media.PlayTo.PlayToConnectionState
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Media.PlayTo
{
  /// <summary>Describes the status of a Play To connection.</summary>
  /// <deprecated type="deprecate">PlayToConnectionState may be altered or unavailable for releases after Windows 10. Instead, use CastingConnectionState.</deprecated>
  [Deprecated("PlayToConnectionState may be altered or unavailable for releases after Windows 10. Instead, use CastingConnectionState.", DeprecationType.Deprecate, 65536, "Windows.Foundation.UniversalApiContract")]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public enum PlayToConnectionState
  {
    /// <summary>The connection is disconnected.</summary>
    Disconnected,
    /// <summary>The connection is connected.</summary>
    Connected,
    /// <summary>The connection is rendering media on the Play To target device.</summary>
    Rendering,
  }
}
