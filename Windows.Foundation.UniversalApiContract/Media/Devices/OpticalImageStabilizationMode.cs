// Decompiled with JetBrains decompiler
// Type: Windows.Media.Devices.OpticalImageStabilizationMode
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Media.Devices
{
  /// <summary>Defines the optical image stabilization modes.</summary>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public enum OpticalImageStabilizationMode
  {
    /// <summary>Optical image stabilization is disabled.</summary>
    Off,
    /// <summary>Optical image stabilization is enabled.</summary>
    On,
    /// <summary>The system dynamically enables optical image stabilization when appropriate.</summary>
    Auto,
  }
}
