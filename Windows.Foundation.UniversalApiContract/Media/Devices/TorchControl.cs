// Decompiled with JetBrains decompiler
// Type: Windows.Media.Devices.TorchControl
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Media.Devices
{
  /// <summary>Provides functionality for controlling the torch LED settings on a capture device.</summary>
  [DualApiPartition(version = 100859904)]
  [MarshalingBehavior(MarshalingType.Standard)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Threading(ThreadingModel.MTA)]
  public sealed class TorchControl : ITorchControl
  {
    /// <summary>Gets a value that specifies if the capture device supports the torch control.</summary>
    /// <returns>**true** if the capture device supports the torch control; otherwise, **false**.</returns>
    public extern bool Supported { [MethodImpl] get; }

    /// <summary>Gets a value that specifics if the device allows the torch LED power settings to be changed.</summary>
    /// <returns>**true** if the power settings can be modified; otherwise, **false**.</returns>
    public extern bool PowerSupported { [MethodImpl] get; }

    /// <summary>Gets or sets a value that enables and disables the torch LED on the device.</summary>
    /// <returns>**true** if the torch LED is enabled; otherwise, **false**.</returns>
    public extern bool Enabled { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets the intensity of the torch LED.</summary>
    /// <returns>The power percent the torch LED is set to.</returns>
    public extern float PowerPercent { [MethodImpl] get; [MethodImpl] set; }
  }
}
