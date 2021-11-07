// Decompiled with JetBrains decompiler
// Type: Windows.Media.Devices.OpticalImageStabilizationControl
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.Media.Devices
{
  /// <summary>When supported, allows an app to enable optical image stabilization on the capture device.</summary>
  [MarshalingBehavior(MarshalingType.Agile)]
  [Threading(ThreadingModel.Both)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [DualApiPartition(version = 167772160)]
  public sealed class OpticalImageStabilizationControl : IOpticalImageStabilizationControl
  {
    /// <summary>Gets a value that indicates if the capture device supports the OpticalImageStabilizationControl.</summary>
    /// <returns>True if the OpticalImageStabilizationControl is supported; otherwise, false.</returns>
    public extern bool Supported { [MethodImpl] get; }

    /// <summary>Gets the list of OpticalImageStabilizationMode values indicating the modes supported by the capture device.</summary>
    /// <returns>The list of supported OpticalImageStabilizationMode values.</returns>
    public extern IVectorView<OpticalImageStabilizationMode> SupportedModes { [MethodImpl] get; }

    /// <summary>Gets or sets a value indicating the current optical image stabilization mode of the capture device.</summary>
    /// <returns>The current optical image stabilization mode of the capture device.</returns>
    public extern OpticalImageStabilizationMode Mode { [MethodImpl] get; [MethodImpl] set; }
  }
}
