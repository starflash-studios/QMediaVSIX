// Decompiled with JetBrains decompiler
// Type: Windows.Media.Core.VideoStabilizationEffectEnabledChangedReason
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Media.Core
{
  /// <summary>Specifies the reason why the VideoStabilizationEffect.Enabled property changed.</summary>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public enum VideoStabilizationEffectEnabledChangedReason
  {
    /// <summary>The value was changed programmatically from app code.</summary>
    Programmatic,
    /// <summary>The pixel rate of the video stream was too high.</summary>
    PixelRateTooHigh,
    /// <summary>The video stabilization effect was running slowly.</summary>
    RunningSlowly,
  }
}
