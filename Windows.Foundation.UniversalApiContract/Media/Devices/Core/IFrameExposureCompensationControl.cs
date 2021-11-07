// Decompiled with JetBrains decompiler
// Type: Windows.Media.Devices.Core.IFrameExposureCompensationControl
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Media.Devices.Core
{
  [ExclusiveTo(typeof (FrameExposureCompensationControl))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(3914897097, 63481, 18634, 133, 145, 162, 101, 49, 203, 21, 120)]
  internal interface IFrameExposureCompensationControl
  {
    IReference<float> Value { get; set; }
  }
}
