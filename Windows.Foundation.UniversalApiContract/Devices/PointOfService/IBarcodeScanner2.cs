// Decompiled with JetBrains decompiler
// Type: Windows.Devices.PointOfService.IBarcodeScanner2
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.PointOfService
{
  [Guid(2300662119, 36078, 17261, 137, 171, 141, 251, 67, 187, 66, 134)]
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  [ExclusiveTo(typeof (BarcodeScanner))]
  internal interface IBarcodeScanner2
  {
    string VideoDeviceId { get; }
  }
}
