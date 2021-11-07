// Decompiled with JetBrains decompiler
// Type: Windows.Media.Casting.CastingConnectionState
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Media.Casting
{
  /// <summary>Indicates the current state of a casting connection. Rendering is used when actively playing content.</summary>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public enum CastingConnectionState
  {
    /// <summary>The casting connection has been disconnected.</summary>
    Disconnected,
    /// <summary>The casting connection is active.</summary>
    Connected,
    /// <summary>The casting connection is actively playing content.</summary>
    Rendering,
    /// <summary>The connection is being disconnected.</summary>
    Disconnecting,
    /// <summary>The connection is connecting.</summary>
    Connecting,
  }
}
