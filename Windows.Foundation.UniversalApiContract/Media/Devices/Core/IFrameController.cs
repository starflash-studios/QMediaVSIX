// Decompiled with JetBrains decompiler
// Type: Windows.Media.Devices.Core.IFrameController
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Media.Devices.Core
{
  [Guid(3244579289, 47855, 16466, 145, 119, 72, 175, 242, 175, 117, 34)]
  [ExclusiveTo(typeof (FrameController))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IFrameController
  {
    FrameExposureControl ExposureControl { get; }

    FrameExposureCompensationControl ExposureCompensationControl { get; }

    FrameIsoSpeedControl IsoSpeedControl { get; }

    FrameFocusControl FocusControl { get; }

    IReference<bool> PhotoConfirmationEnabled { get; set; }
  }
}
