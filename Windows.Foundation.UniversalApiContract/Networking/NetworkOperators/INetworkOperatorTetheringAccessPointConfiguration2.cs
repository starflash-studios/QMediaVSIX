// Decompiled with JetBrains decompiler
// Type: Windows.Networking.NetworkOperators.INetworkOperatorTetheringAccessPointConfiguration2
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Networking.NetworkOperators
{
  [ExclusiveTo(typeof (NetworkOperatorTetheringAccessPointConfiguration))]
  [Guid(2977993026, 29240, 22944, 146, 139, 116, 171, 70, 253, 100, 182)]
  [ContractVersion(typeof (UniversalApiContract), 655360)]
  internal interface INetworkOperatorTetheringAccessPointConfiguration2
  {
    bool IsBandSupported(TetheringWiFiBand band);

    [RemoteAsync]
    IAsyncOperation<bool> IsBandSupportedAsync(TetheringWiFiBand band);

    TetheringWiFiBand Band { get; set; }
  }
}
