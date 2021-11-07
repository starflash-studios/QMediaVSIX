// Decompiled with JetBrains decompiler
// Type: Windows.Networking.Sockets.RoundTripTimeStatistics
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Networking.Sockets
{
  /// <summary>Represents round trip time information for a StreamSocket object.</summary>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public struct RoundTripTimeStatistics
  {
    /// <summary>The round trip time variation, in microseconds, for a StreamSocket object. This value is used for receive window auto-tuning.</summary>
    public uint Variance;
    /// <summary>The maximum sampled round trip time, in microseconds, for a StreamSocket object.</summary>
    public uint Max;
    /// <summary>The minimum sampled round trip time, in microseconds, for a StreamSocket object.</summary>
    public uint Min;
    /// <summary>A smoothed value round trip time, in microseconds, computed from all sampled round trip times for a StreamSocket object. The smoothing is a weighted additive function that uses the  member.</summary>
    public uint Sum;
  }
}
