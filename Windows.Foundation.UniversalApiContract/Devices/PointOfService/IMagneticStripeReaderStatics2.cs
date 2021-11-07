// Decompiled with JetBrains decompiler
// Type: Windows.Devices.PointOfService.IMagneticStripeReaderStatics2
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.PointOfService
{
  [Guid(2360197986, 54887, 18682, 134, 188, 245, 174, 17, 137, 38, 43)]
  [ExclusiveTo(typeof (MagneticStripeReader))]
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  internal interface IMagneticStripeReaderStatics2
  {
    [Overload("GetDeviceSelectorWithConnectionTypes")]
    string GetDeviceSelector(PosConnectionTypes connectionTypes);
  }
}
