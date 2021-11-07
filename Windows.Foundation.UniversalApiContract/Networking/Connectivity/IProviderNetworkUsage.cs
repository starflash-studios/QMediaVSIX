// Decompiled with JetBrains decompiler
// Type: Windows.Networking.Connectivity.IProviderNetworkUsage
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Networking.Connectivity
{
  [Guid(1590074884, 31025, 18632, 184, 243, 70, 48, 15, 164, 39, 40)]
  [ContractVersion(typeof (UniversalApiContract), 327680)]
  [ExclusiveTo(typeof (ProviderNetworkUsage))]
  internal interface IProviderNetworkUsage
  {
    ulong BytesSent { get; }

    ulong BytesReceived { get; }

    string ProviderId { get; }
  }
}
