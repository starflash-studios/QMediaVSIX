// Decompiled with JetBrains decompiler
// Type: Windows.Networking.Sockets.IStreamSocketInformation
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Storage.Streams;

namespace Windows.Networking.Sockets
{
  [ExclusiveTo(typeof (StreamSocketInformation))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(998288944, 24168, 16901, 136, 240, 220, 133, 210, 226, 93, 237)]
  internal interface IStreamSocketInformation
  {
    HostName LocalAddress { get; }

    string LocalPort { get; }

    HostName RemoteHostName { get; }

    HostName RemoteAddress { get; }

    string RemoteServiceName { get; }

    string RemotePort { get; }

    RoundTripTimeStatistics RoundTripTimeStatistics { get; }

    BandwidthStatistics BandwidthStatistics { get; }

    SocketProtectionLevel ProtectionLevel { get; }

    IBuffer SessionKey { get; }
  }
}
