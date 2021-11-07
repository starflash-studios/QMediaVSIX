// Decompiled with JetBrains decompiler
// Type: Windows.Media.Devices.VideoTemporalDenoisingMode
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Media.Devices
{
  /// <summary>Defines the video temporal denoising modes.</summary>
  [ContractVersion(typeof (UniversalApiContract), 393216)]
  public enum VideoTemporalDenoisingMode
  {
    /// <summary>Temporal denoising is off.</summary>
    Off,
    /// <summary>Temporal denoising is on.</summary>
    On,
    /// <summary>The system dynamically enables temporal denoising when appropriate.</summary>
    Auto,
  }
}
