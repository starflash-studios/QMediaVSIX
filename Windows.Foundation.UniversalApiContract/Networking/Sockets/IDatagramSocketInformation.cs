// Decompiled with JetBrains decompiler
// Type: Windows.Networking.Sockets.IDatagramSocketInformation
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Networking.Sockets
{
  [Guid(1595561626, 22011, 18637, 151, 6, 122, 151, 79, 123, 21, 133)]
  [ExclusiveTo(typeof (DatagramSocketInformation))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IDatagramSocketInformation
  {
    HostName LocalAddress { get; }

    string LocalPort { get; }

    HostName RemoteAddress { get; }

    string RemotePort { get; }
  }
}
