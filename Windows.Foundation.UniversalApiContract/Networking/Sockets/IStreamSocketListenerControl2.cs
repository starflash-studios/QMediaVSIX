// Decompiled with JetBrains decompiler
// Type: Windows.Networking.Sockets.IStreamSocketListenerControl2
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Networking.Sockets
{
  [ExclusiveTo(typeof (StreamSocketListenerControl))]
  [Guid(2492184165, 11326, 16459, 184, 176, 142, 178, 73, 162, 176, 161)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IStreamSocketListenerControl2
  {
    bool NoDelay { get; set; }

    bool KeepAlive { get; set; }

    uint OutboundBufferSizeInBytes { get; set; }

    byte OutboundUnicastHopLimit { get; set; }
  }
}
