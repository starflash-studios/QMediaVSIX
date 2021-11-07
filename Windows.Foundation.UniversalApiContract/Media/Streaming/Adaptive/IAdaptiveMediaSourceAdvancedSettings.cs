// Decompiled with JetBrains decompiler
// Type: Windows.Media.Streaming.Adaptive.IAdaptiveMediaSourceAdvancedSettings
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Media.Streaming.Adaptive
{
  [Guid(1440421504, 6891, 18396, 170, 8, 154, 17, 97, 11, 164, 90)]
  [ExclusiveTo(typeof (AdaptiveMediaSourceAdvancedSettings))]
  [ContractVersion(typeof (UniversalApiContract), 131072)]
  internal interface IAdaptiveMediaSourceAdvancedSettings
  {
    bool AllSegmentsIndependent { get; set; }

    IReference<double> DesiredBitrateHeadroomRatio { get; set; }

    IReference<double> BitrateDowngradeTriggerRatio { get; set; }
  }
}
