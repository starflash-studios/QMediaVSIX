// Decompiled with JetBrains decompiler
// Type: Windows.Media.Devices.FocusSettings
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Media.Devices
{
  /// <summary>Represents settings for a FocusControl object.</summary>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [DualApiPartition(version = 167772160)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [Activatable(65536, "Windows.Foundation.UniversalApiContract")]
  [Threading(ThreadingModel.Both)]
  public sealed class FocusSettings : IFocusSettings
  {
    /// <summary>Initializes a new instance of the FocusSettings class.</summary>
    [MethodImpl]
    public extern FocusSettings();

    /// <summary>Gets or sets a value indicating the focus mode setting.</summary>
    /// <returns>A value indicating the focus mode setting.</returns>
    public extern FocusMode Mode { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets a value indicating the auto focus range setting.</summary>
    /// <returns>A value indicating the auto focus range setting.</returns>
    public extern AutoFocusRange AutoFocusRange { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets the focus value setting.</summary>
    /// <returns>The focus value setting.</returns>
    public extern IReference<uint> Value { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets a value indicating the manual focus distance setting.</summary>
    /// <returns>A value indicating the manual focus distance setting.</returns>
    public extern IReference<ManualFocusDistance> Distance { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets a value indicating whether the capture device should wait for focus before capturing.</summary>
    /// <returns>A value indicating whether the capture device should wait for focus before capturing.</returns>
    public extern bool WaitForFocus { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets a value that indicates to the driver if it should disable determining a focus position when the focus search fails.</summary>
    /// <returns>**true** if the driver should not determine a focus position if the focus search fails. **false** if the driver should determine a focus position if the focus search fails.</returns>
    public extern bool DisableDriverFallback { [MethodImpl] get; [MethodImpl] set; }
  }
}
