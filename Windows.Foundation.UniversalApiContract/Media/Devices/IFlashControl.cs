// Decompiled with JetBrains decompiler
// Type: Windows.Media.Devices.IFlashControl
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Media.Devices
{
  [ExclusiveTo(typeof (FlashControl))]
  [Guid(3740540350, 32104, 17891, 140, 15, 190, 123, 179, 40, 55, 208)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IFlashControl
  {
    bool Supported { get; }

    bool PowerSupported { get; }

    bool RedEyeReductionSupported { get; }

    bool Enabled { get; set; }

    bool Auto { get; set; }

    bool RedEyeReduction { get; set; }

    float PowerPercent { get; set; }
  }
}
