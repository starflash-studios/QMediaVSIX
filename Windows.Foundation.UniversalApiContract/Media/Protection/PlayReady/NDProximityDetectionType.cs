// Decompiled with JetBrains decompiler
// Type: Windows.Media.Protection.PlayReady.NDProximityDetectionType
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Media.Protection.PlayReady
{
  /// <summary>Indicates the transport protocol that the proximity detection process uses.</summary>
  /// <deprecated type="deprecate">NDProximityDetectionType is deprecated and might not work on all platforms. For more info, see MSDN.</deprecated>
  [Deprecated("NDProximityDetectionType is deprecated and might not work on all platforms. For more info, see MSDN.", DeprecationType.Deprecate, 196608, "Windows.Foundation.UniversalApiContract")]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public enum NDProximityDetectionType
  {
    /// <summary>Proximity detection uses the UDP transport protocol.</summary>
    UDP = 1,
    /// <summary>Proximity detection uses the TCP transport protocol.</summary>
    TCP = 2,
    /// <summary>Proximity detection can use either UDP or TCP as the transport protocol.</summary>
    TransportAgnostic = 4,
  }
}
