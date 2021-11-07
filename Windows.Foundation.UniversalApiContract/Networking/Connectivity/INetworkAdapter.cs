// Decompiled with JetBrains decompiler
// Type: Windows.Networking.Connectivity.INetworkAdapter
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Networking.Connectivity
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(995372547, 21384, 18796, 168, 163, 175, 253, 57, 174, 194, 230)]
  [ExclusiveTo(typeof (NetworkAdapter))]
  internal interface INetworkAdapter
  {
    ulong OutboundMaxBitsPerSecond { get; }

    ulong InboundMaxBitsPerSecond { get; }

    uint IanaInterfaceType { get; }

    NetworkItem NetworkItem { get; }

    Guid NetworkAdapterId { get; }

    [RemoteAsync]
    IAsyncOperation<ConnectionProfile> GetConnectedProfileAsync();
  }
}
