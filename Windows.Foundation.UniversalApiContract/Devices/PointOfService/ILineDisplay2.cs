// Decompiled with JetBrains decompiler
// Type: Windows.Devices.PointOfService.ILineDisplay2
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.PointOfService
{
  [ExclusiveTo(typeof (LineDisplay))]
  [Guid(3264652840, 61252, 16627, 189, 28, 176, 76, 106, 92, 220, 125)]
  [ContractVersion(typeof (UniversalApiContract), 327680)]
  internal interface ILineDisplay2
  {
    [RemoteAsync]
    IAsyncOperation<LineDisplayPowerStatus> CheckPowerStatusAsync();
  }
}
