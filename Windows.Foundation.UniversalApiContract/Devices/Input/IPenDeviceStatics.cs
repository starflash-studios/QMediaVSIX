// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Input.IPenDeviceStatics
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.Input
{
  [ExclusiveTo(typeof (PenDevice))]
  [ContractVersion(typeof (UniversalApiContract), 524288)]
  [Guid(2650521089, 2406, 20864, 188, 180, 184, 80, 96, 227, 148, 121)]
  internal interface IPenDeviceStatics
  {
    PenDevice GetFromPointerId(uint pointerId);
  }
}
