// Decompiled with JetBrains decompiler
// Type: Windows.Media.Devices.PanelBasedOptimizationControl
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Devices.Enumeration;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Media.Devices
{
  /// <summary>When supported, allows an app to enable the capture device driver to optimize camera capture functionality based on the panel location of the camera.</summary>
  [ContractVersion(typeof (UniversalApiContract), 655360)]
  [DualApiPartition(version = 1)]
  [MarshalingBehavior(MarshalingType.Agile)]
  public sealed class PanelBasedOptimizationControl : IPanelBasedOptimizationControl
  {
    /// <summary>Gets a value indicating whether photo confirmation is supported by the capture device.</summary>
    /// <returns>A value indicating whether photo confirmation is supported by the capture device.</returns>
    public extern bool IsSupported { [MethodImpl] get; }

    /// <summary>Gets or sets the panel on which the camera is located, allowing the camera driver to optimize capture based on the camera location.</summary>
    /// <returns>A value from the Windows.Devices.Enumeration.Panel enumeration, indicating the location of the camera.</returns>
    public extern Panel Panel { [MethodImpl] get; [MethodImpl] set; }
  }
}
