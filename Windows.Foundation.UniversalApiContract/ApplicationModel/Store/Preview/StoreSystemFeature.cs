// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Store.Preview.StoreSystemFeature
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Store.Preview
{
  /// <summary>Defines values that represent hardware features that can be queried for the current device by using the FilterUnsupportedSystemFeaturesAsync method.</summary>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public enum StoreSystemFeature
  {
    /// <summary>The device chipset uses the x86 CPU architecture.</summary>
    ArchitectureX86,
    /// <summary>The device chipset uses the x64 CPU architecture.</summary>
    ArchitectureX64,
    /// <summary>The device chipset uses the ARM CPU architecture.</summary>
    ArchitectureArm,
    /// <summary>The device supports DirectX9.</summary>
    DirectX9,
    /// <summary>The device supports DirectX10.</summary>
    DirectX10,
    /// <summary>The device supports DirectX11.</summary>
    DirectX11,
    /// <summary>The device supports Direct3D 12 feature level 12.0.</summary>
    D3D12HardwareFL11,
    /// <summary>The device supports Direct3D 12 feature level 12.1.</summary>
    D3D12HardwareFL12,
    /// <summary>The device has 300 MB of RAM.</summary>
    Memory300MB,
    /// <summary>The device has 750 MB of RAM.</summary>
    Memory750MB,
    /// <summary>The device has 1 GB of RAM.</summary>
    Memory1GB,
    /// <summary>The device has 2 GB of RAM.</summary>
    Memory2GB,
    /// <summary>The device has a front-facing camera.</summary>
    CameraFront,
    /// <summary>The device has a rear-facing camera.</summary>
    CameraRear,
    /// <summary>The device has a gyroscope.</summary>
    Gyroscope,
    /// <summary>The device supports hover touch.</summary>
    Hover,
    /// <summary>The device has a magnetometer.</summary>
    Magnetometer,
    /// <summary>The device includes an NFC device.</summary>
    Nfc,
    /// <summary>The display resolution is 720p.</summary>
    Resolution720P,
    /// <summary>The display resolution is WVGA.</summary>
    ResolutionWvga,
    /// <summary>The display resolution is 720p or WVGA.</summary>
    ResolutionWvgaOr720P,
    /// <summary>The display resolution is WXGA</summary>
    ResolutionWxga,
    /// <summary>The display resolution is WVGA or WXGA.</summary>
    ResolutionWvgaOrWxga,
    /// <summary>The display resolution is WXGA or 720p.</summary>
    ResolutionWxgaOr720P,
    /// <summary>The device has 4 GB of memory.</summary>
    [ContractVersion("Windows.Foundation.UniversalApiContract", 196608)] Memory4GB,
    /// <summary>The device has 6 GB of memory.</summary>
    [ContractVersion("Windows.Foundation.UniversalApiContract", 196608)] Memory6GB,
    /// <summary>The device has 8 GB of memory.</summary>
    [ContractVersion("Windows.Foundation.UniversalApiContract", 196608)] Memory8GB,
    /// <summary>The device has 12 GB of memory.</summary>
    [ContractVersion("Windows.Foundation.UniversalApiContract", 196608)] Memory12GB,
    /// <summary>The device has 16 GB of memory.</summary>
    [ContractVersion("Windows.Foundation.UniversalApiContract", 196608)] Memory16GB,
    /// <summary>The device has 20 GB of memory.</summary>
    [ContractVersion("Windows.Foundation.UniversalApiContract", 196608)] Memory20GB,
    /// <summary>The device has 2 GB of video memory.</summary>
    [ContractVersion("Windows.Foundation.UniversalApiContract", 196608)] VideoMemory2GB,
    /// <summary>The device has4 GB of video memory.</summary>
    [ContractVersion("Windows.Foundation.UniversalApiContract", 196608)] VideoMemory4GB,
    /// <summary>The device has 6 GB of video memory.</summary>
    [ContractVersion("Windows.Foundation.UniversalApiContract", 196608)] VideoMemory6GB,
    /// <summary>The device has 1 GB of video memory.</summary>
    [ContractVersion("Windows.Foundation.UniversalApiContract", 196608)] VideoMemory1GB,
    /// <summary>The device chipset uses the ARM64 CPU architecture.</summary>
    [ContractVersion("Windows.Foundation.UniversalApiContract", 393216)] ArchitectureArm64,
  }
}
