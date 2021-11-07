// Decompiled with JetBrains decompiler
// Type: Windows.Media.Devices.IAdvancedVideoCaptureDeviceController8
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Media.Devices
{
  [ExclusiveTo(typeof (VideoDeviceController))]
  [ContractVersion(typeof (UniversalApiContract), 655360)]
  [Guid(3628331024, 59387, 22875, 154, 120, 14, 84, 196, 83, 43, 67)]
  internal interface IAdvancedVideoCaptureDeviceController8
  {
    PanelBasedOptimizationControl PanelBasedOptimizationControl { get; }
  }
}
