// Decompiled with JetBrains decompiler
// Type: Windows.Media.Devices.FlashControl
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Media.Devices
{
  /// <summary>Provides functionality for controlling the flash settings on a capture device.</summary>
  [Threading(ThreadingModel.MTA)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [MarshalingBehavior(MarshalingType.Standard)]
  [DualApiPartition(version = 100859904)]
  public sealed class FlashControl : IFlashControl, IFlashControl2
  {
    /// <summary>Gets a value that specifies if the capture device supports the flash control.</summary>
    /// <returns>**true** if the capture device supports the FlashControl; otherwise, **false**.</returns>
    public extern bool Supported { [MethodImpl] get; }

    /// <summary>Gets a value that specifics if the device allows the torch LED power settings to be changed.</summary>
    /// <returns>**true** if the device allows the torch LED power settings to be changed; otherwise, **false**.</returns>
    public extern bool PowerSupported { [MethodImpl] get; }

    /// <summary>Gets a value that specifies if the capture device supports red eye reduction.</summary>
    /// <returns>**true** if the capture device supports red eye reduction; otherwise, **false**.</returns>
    public extern bool RedEyeReductionSupported { [MethodImpl] get; }

    /// <summary>Gets a value that specifies if the flash on the capture device is enabled or disabled.</summary>
    /// <returns>**true** if the flash is enabled; otherwise, **false**.</returns>
    public extern bool Enabled { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets a value that specifies if flash is automatically set.</summary>
    /// <returns>**true** if auto flash is set; otherwise, **false**.</returns>
    public extern bool Auto { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets a value that specifies if the red eye reduction is enabled or disabled.</summary>
    /// <returns>**true** if red eye reduction is enabled; otherwise, **false**.</returns>
    public extern bool RedEyeReduction { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets the intensity of the flash.</summary>
    /// <returns>The power percent the torch LED is set to.</returns>
    public extern float PowerPercent { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets a value indicating whether focus assist light is supported by the capture device.</summary>
    /// <returns>A value indicating whether focus assist light is supported by the capture device.</returns>
    public extern bool AssistantLightSupported { [MethodImpl] get; }

    /// <summary>Gets or sets a value indicating whether focus assist light is enabled on the capture device.</summary>
    /// <returns>A value indicating whether focus assist light is enabled on the capture device.</returns>
    public extern bool AssistantLightEnabled { [MethodImpl] get; [MethodImpl] set; }
  }
}
