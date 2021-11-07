// Decompiled with JetBrains decompiler
// Type: Windows.Media.Devices.InfraredTorchControl
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.Media.Devices
{
  /// <summary>Provides functionality for controlling the infrared torch LED settings on a capture device.</summary>
  [ContractVersion(typeof (UniversalApiContract), 524288)]
  [MarshalingBehavior(MarshalingType.Agile)]
  public sealed class InfraredTorchControl : IInfraredTorchControl
  {
    /// <summary>Gets a value that indicates if the capture device supports the InfraredTorchControl.</summary>
    /// <returns>**true** if the infrared control is supported; otherwise, **false**.</returns>
    public extern bool IsSupported { [MethodImpl] get; }

    /// <summary>SupportedModes property is used to find out modes that the infrared LED supports.</summary>
    /// <returns>Read-only list of supported InfraredTorchModes.</returns>
    public extern IVectorView<InfraredTorchMode> SupportedModes { [MethodImpl] get; }

    /// <summary>Gets the current operation mode of the infrared LED.</summary>
    /// <returns>The current operation mode of the infrared LED.</returns>
    public extern InfraredTorchMode CurrentMode { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets the minimum infrared LED power value supported by the capture device.</summary>
    /// <returns>The minimum infrared LED power value supported by the capture device.</returns>
    public extern int MinPower { [MethodImpl] get; }

    /// <summary>Gets the maximum infrared LED power value supported by the capture device.</summary>
    /// <returns>The maximum infrared LED power value supported by the capture device.</returns>
    public extern int MaxPower { [MethodImpl] get; }

    /// <summary>Gets the supported power step value.</summary>
    /// <returns>The supported power step value.</returns>
    public extern int PowerStep { [MethodImpl] get; }

    /// <summary>Gets or sets the current infrared LED power value.</summary>
    /// <returns>The power value the infrared LED is set to.</returns>
    public extern int Power { [MethodImpl] get; [MethodImpl] set; }
  }
}
