// Decompiled with JetBrains decompiler
// Type: Windows.Devices.PointOfService.ICashDrawerStatics
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.PointOfService
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (CashDrawer))]
  [Guid(3751843162, 54327, 20479, 181, 71, 221, 169, 105, 164, 248, 131)]
  internal interface ICashDrawerStatics
  {
    [RemoteAsync]
    IAsyncOperation<CashDrawer> GetDefaultAsync();

    [RemoteAsync]
    IAsyncOperation<CashDrawer> FromIdAsync(string deviceId);

    string GetDeviceSelector();
  }
}
