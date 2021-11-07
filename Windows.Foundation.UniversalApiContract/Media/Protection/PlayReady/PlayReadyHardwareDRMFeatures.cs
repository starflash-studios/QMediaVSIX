// Decompiled with JetBrains decompiler
// Type: Windows.Media.Protection.PlayReady.PlayReadyHardwareDRMFeatures
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Media.Protection.PlayReady
{
  /// <summary>Indicates the valid list of hardware digital rights management (DRM) feature values that can be queried.</summary>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public enum PlayReadyHardwareDRMFeatures
  {
    /// <summary>Hardware DRM is supported on the machine.</summary>
    HardwareDRM = 1,
    /// <summary>Indicates the hardware supports High Efficiency Video Coding (HEVC)/H.265 codec.</summary>
    HEVC = 2,
    /// <summary>Indicates the hardware supports AES128CBC encryption.</summary>
    [ContractVersion("Windows.Foundation.UniversalApiContract", 327680)] Aes128Cbc = 3,
  }
}
