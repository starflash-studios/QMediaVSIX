// Decompiled with JetBrains decompiler
// Type: Windows.UI.WindowManagement.DisplayRegion
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.WindowManagement
{
  /// <summary>Represents the region in which a view is able to be shown to a user on a logical display.</summary>
  [ContractVersion(typeof (UniversalApiContract), 524288)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [WebHostHidden]
  public sealed class DisplayRegion : IDisplayRegion
  {
    /// <summary>Gets the device ID for the monitor associated with the display region.</summary>
    /// <returns>The device ID for the monitor associated with the display region.</returns>
    public extern string DisplayMonitorDeviceId { [MethodImpl] get; }

    /// <summary>Gets a value that indicates whether the display region can be seen.</summary>
    /// <returns>**true** if the display region can be seen; otherwise, **false**.</returns>
    public extern bool IsVisible { [MethodImpl] get; }

    /// <summary>Gets the offset within the display coordinate space for this DisplayRegion.</summary>
    /// <returns>The offset within the display coordinate space for this DisplayRegion.</returns>
    public extern Point WorkAreaOffset { [MethodImpl] get; }

    /// <summary>Gets the width and height of the display region.</summary>
    /// <returns>The width and height of the display region.</returns>
    public extern Size WorkAreaSize { [MethodImpl] get; }

    /// <summary>Gets the windowing environment that this display region exists in.</summary>
    /// <returns>The windowing environment that this display region exists in.</returns>
    public extern WindowingEnvironment WindowingEnvironment { [MethodImpl] get; }

    /// <summary>Occurs when a property of the display region has changed.</summary>
    public extern event TypedEventHandler<DisplayRegion, object> Changed;
  }
}
