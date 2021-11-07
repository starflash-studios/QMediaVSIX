// Decompiled with JetBrains decompiler
// Type: Windows.Networking.Sockets.IDatagramSocketControl
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Networking.Sockets
{
  [ExclusiveTo(typeof (DatagramSocketControl))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(1387020078, 13466, 16693, 187, 88, 183, 155, 38, 71, 211, 144)]
  internal interface IDatagramSocketControl
  {
    SocketQualityOfService QualityOfService { get; set; }

    byte OutboundUnicastHopLimit { get; set; }
  }
}
