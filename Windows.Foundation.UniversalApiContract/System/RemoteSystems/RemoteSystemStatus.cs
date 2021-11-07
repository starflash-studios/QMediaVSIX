// Decompiled with JetBrains decompiler
// Type: Windows.System.RemoteSystems.RemoteSystemStatus
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.System.RemoteSystems
{
  /// <summary>Contains the values that describe a remote system's availability status.</summary>
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  public enum RemoteSystemStatus
  {
    /// <summary>The remote system is unavailable.</summary>
    Unavailable,
    /// <summary>The availability of the remote system is currently being discovered.</summary>
    DiscoveringAvailability,
    /// <summary>The remote system is available.</summary>
    Available,
    /// <summary>The availability of the remote system is unknown.</summary>
    Unknown,
  }
}
