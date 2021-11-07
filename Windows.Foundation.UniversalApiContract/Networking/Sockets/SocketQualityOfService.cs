// Decompiled with JetBrains decompiler
// Type: Windows.Networking.Sockets.SocketQualityOfService
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Networking.Sockets
{
  /// <summary>Specifies the quality of service for a DatagramSocket or StreamSocket object.</summary>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public enum SocketQualityOfService
  {
    /// <summary>Normal quality of service.</summary>
    Normal,
    /// <summary>Low latency quality of service commonly used for audio.</summary>
    LowLatency,
  }
}
