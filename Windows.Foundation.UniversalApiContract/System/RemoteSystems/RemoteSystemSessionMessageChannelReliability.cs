// Decompiled with JetBrains decompiler
// Type: Windows.System.RemoteSystems.RemoteSystemSessionMessageChannelReliability
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.System.RemoteSystems
{
  /// <summary>Contains values that describe the reliability type of a remote session messaging channel.</summary>
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  public enum RemoteSystemSessionMessageChannelReliability
  {
    /// <summary>The channel is connection-based. Delivery of packets is guaranteed as long as the connection remains open.</summary>
    Reliable,
    /// <summary>The channel is connectionless. Delivery of packets is not guaranteed.</summary>
    Unreliable,
  }
}
