// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Input.MouseDevice
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.Input
{
  /// <summary>Supports the ability to identify and track connected mouse devices.</summary>
  [MarshalingBehavior(MarshalingType.Standard)]
  [Static(typeof (IMouseDeviceStatics), 65536, "Windows.Foundation.UniversalApiContract")]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public sealed class MouseDevice : IMouseDevice
  {
    /// <summary>Occurs when the mouse pointer is moved.</summary>
    public extern event TypedEventHandler<MouseDevice, MouseEventArgs> MouseMoved;

    /// <summary>Retrieves the mouse device that is associated with the current view.</summary>
    /// <returns>The mouse device.</returns>
    [MethodImpl]
    public static extern MouseDevice GetForCurrentView();
  }
}
