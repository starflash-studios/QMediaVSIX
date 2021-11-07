// Decompiled with JetBrains decompiler
// Type: Windows.Media.Devices.Core.IFrameFlashControl
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Media.Devices.Core
{
  [Guid(1976956615, 48453, 20395, 147, 117, 69, 172, 4, 179, 50, 194)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (FrameFlashControl))]
  internal interface IFrameFlashControl
  {
    FrameFlashMode Mode { get; set; }

    bool Auto { get; set; }

    bool RedEyeReduction { get; set; }

    float PowerPercent { get; set; }
  }
}
