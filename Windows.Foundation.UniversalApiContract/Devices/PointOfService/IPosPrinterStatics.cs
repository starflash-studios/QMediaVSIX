// Decompiled with JetBrains decompiler
// Type: Windows.Devices.PointOfService.IPosPrinterStatics
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.PointOfService
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (PosPrinter))]
  [Guid(2363544810, 4911, 19679, 166, 74, 45, 13, 124, 150, 168, 91)]
  internal interface IPosPrinterStatics
  {
    [RemoteAsync]
    IAsyncOperation<PosPrinter> GetDefaultAsync();

    [RemoteAsync]
    IAsyncOperation<PosPrinter> FromIdAsync(string deviceId);

    string GetDeviceSelector();
  }
}
