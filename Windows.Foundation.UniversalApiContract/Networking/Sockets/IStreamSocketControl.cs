// Decompiled with JetBrains decompiler
// Type: Windows.Networking.Sockets.IStreamSocketControl
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Networking.Sockets
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(4263882225, 37547, 19187, 153, 146, 15, 76, 133, 227, 108, 196)]
  [ExclusiveTo(typeof (StreamSocketControl))]
  internal interface IStreamSocketControl
  {
    bool NoDelay { get; set; }

    bool KeepAlive { get; set; }

    uint OutboundBufferSizeInBytes { get; set; }

    SocketQualityOfService QualityOfService { get; set; }

    byte OutboundUnicastHopLimit { get; set; }
  }
}
