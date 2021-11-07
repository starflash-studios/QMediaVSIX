// Decompiled with JetBrains decompiler
// Type: Windows.Media.Devices.WhiteBalanceControl
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Media.Devices
{
  /// <summary>Provides functionality for controlling the white balance settings on a capture device.</summary>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [DualApiPartition(version = 100859904)]
  [Threading(ThreadingModel.MTA)]
  [MarshalingBehavior(MarshalingType.Standard)]
  public sealed class WhiteBalanceControl : IWhiteBalanceControl
  {
    /// <summary>Gets a value that specifies if the capture device supports the white balance control.</summary>
    /// <returns>**true** if the capture device supports the white balance control; otherwise, **false**.</returns>
    public extern bool Supported { [MethodImpl] get; }

    /// <summary>Gets the color temperature preset.</summary>
    /// <returns>The color temperature preset.</returns>
    public extern ColorTemperaturePreset Preset { [MethodImpl] get; }

    /// <summary>Asynchronously sets the color temperature Preset.</summary>
    /// <param name="preset">The color temperate preset to set the Preset property to.</param>
    /// <returns>The object that is used to control the asynchronous operation.</returns>
    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncAction SetPresetAsync(ColorTemperaturePreset preset);

    /// <summary>Gets the minimum white balance value.</summary>
    /// <returns>The minimum white balance value.</returns>
    public extern uint Min { [MethodImpl] get; }

    /// <summary>Gets the maximum white balance value.</summary>
    /// <returns>The maximum white balance value.</returns>
    public extern uint Max { [MethodImpl] get; }

    /// <summary>Gets the step value.</summary>
    /// <returns>The step value.</returns>
    public extern uint Step { [MethodImpl] get; }

    /// <summary>Gets the color temperature value.</summary>
    /// <returns>The color temperature value.</returns>
    public extern uint Value { [MethodImpl] get; }

    /// <summary>Asynchronously sets the color temperature Value.</summary>
    /// <param name="temperature">The temperature value to set the Value property to.</param>
    /// <returns>The object that is used to control the asynchronous operation.</returns>
    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncAction SetValueAsync(uint temperature);
  }
}
