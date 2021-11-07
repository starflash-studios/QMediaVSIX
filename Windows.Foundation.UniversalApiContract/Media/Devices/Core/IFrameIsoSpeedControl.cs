// Decompiled with JetBrains decompiler
// Type: Windows.Media.Devices.Core.IFrameIsoSpeedControl
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Media.Devices.Core
{
  [Guid(436465645, 30826, 19573, 165, 87, 122, 185, 168, 95, 88, 140)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (FrameIsoSpeedControl))]
  internal interface IFrameIsoSpeedControl
  {
    bool Auto { get; set; }

    IReference<uint> Value { get; set; }
  }
}
