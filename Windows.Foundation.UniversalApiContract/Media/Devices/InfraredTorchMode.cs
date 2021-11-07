// Decompiled with JetBrains decompiler
// Type: Windows.Media.Devices.InfraredTorchMode
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Media.Devices
{
  /// <summary>Defines the Infrared torch modes.</summary>
  [ContractVersion(typeof (UniversalApiContract), 524288)]
  public enum InfraredTorchMode
  {
    /// <summary>“Off” mode means that the infrared LED is constantly off</summary>
    Off,
    /// <summary>“On” mode means that the infrared LED is constantly on</summary>
    On,
    /// <summary>“AlternatingFrameIllumination” mode means that the infrared LED is on for every other frame.</summary>
    AlternatingFrameIllumination,
  }
}
