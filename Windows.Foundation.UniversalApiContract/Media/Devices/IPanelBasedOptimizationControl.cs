// Decompiled with JetBrains decompiler
// Type: Windows.Media.Devices.IPanelBasedOptimizationControl
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Devices.Enumeration;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Media.Devices
{
  [Guid(858927651, 25159, 21529, 165, 164, 61, 128, 134, 69, 217, 23)]
  [ExclusiveTo(typeof (PanelBasedOptimizationControl))]
  [ContractVersion(typeof (UniversalApiContract), 655360)]
  internal interface IPanelBasedOptimizationControl
  {
    bool IsSupported { get; }

    Panel Panel { get; set; }
  }
}
