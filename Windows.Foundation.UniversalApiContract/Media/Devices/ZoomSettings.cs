// Decompiled with JetBrains decompiler
// Type: Windows.Media.Devices.ZoomSettings
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Media.Devices
{
  /// <summary>Represents zoom settings that can be applied to the ZoomControl by calling the Configure method.</summary>
  [MarshalingBehavior(MarshalingType.Agile)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Threading(ThreadingModel.Both)]
  [Activatable(65536, "Windows.Foundation.UniversalApiContract")]
  [DualApiPartition(version = 167772160)]
  public sealed class ZoomSettings : IZoomSettings
  {
    /// <summary>Initializes a new instance of the ZoomSettings class.</summary>
    [MethodImpl]
    public extern ZoomSettings();

    /// <summary>Gets or sets a ZoomTransitionMode value indicating how the capture device should transition to the new zoom value specified with the Value property.</summary>
    /// <returns>A value indicating how the capture device should transition to the new zoom value.</returns>
    public extern ZoomTransitionMode Mode { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets the zoom value to which the ZoomControl will transition.</summary>
    /// <returns>The zoom value to which the ZoomControl will transition.</returns>
    public extern float Value { [MethodImpl] get; [MethodImpl] set; }
  }
}
