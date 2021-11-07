// Decompiled with JetBrains decompiler
// Type: Windows.Media.Devices.AdvancedPhotoControl
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.Media.Devices
{
  /// <summary>Provides functionality for controlling the advanced photo capture behavior on a capture device.</summary>
  [MarshalingBehavior(MarshalingType.Agile)]
  [Threading(ThreadingModel.Both)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [DualApiPartition(version = 167772160)]
  public sealed class AdvancedPhotoControl : IAdvancedPhotoControl
  {
    /// <summary>Gets a value indicating whether the AdvancedPhotoControl is supported on the current capture device.</summary>
    /// <returns>True if the AdvancedPhotoControl is supported; otherwise, false.</returns>
    public extern bool Supported { [MethodImpl] get; }

    /// <summary>Gets a list of the advanced capture modes supported by the current capture device.</summary>
    /// <returns>A list of the advanced capture modes supported by the current capture device.</returns>
    public extern IVectorView<AdvancedPhotoMode> SupportedModes { [MethodImpl] get; }

    /// <summary>Gets the current advanced capture mode of the AdvancedPhotoControl.</summary>
    /// <returns>The current advanced capture mode of the AdvancedPhotoControl.</returns>
    public extern AdvancedPhotoMode Mode { [MethodImpl] get; }

    /// <summary>Configures the AdvancedPhotoControl object with the specified settings.</summary>
    /// <param name="settings">The object defining the configuration settings.</param>
    [MethodImpl]
    public extern void Configure(AdvancedPhotoCaptureSettings settings);
  }
}
