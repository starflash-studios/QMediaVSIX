// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Input.PointerDevice
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.Devices.Input
{
  /// <summary>Supports the ability to identify the connected pointer devices and determine their capabilities.</summary>
  [Muse(Version = 100859904)]
  [MarshalingBehavior(MarshalingType.None)]
  [Static(typeof (IPointerDeviceStatics), 65536, "Windows.Foundation.UniversalApiContract")]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public sealed class PointerDevice : IPointerDevice, IPointerDevice2
  {
    /// <summary>Gets the pointer device type.</summary>
    /// <returns>A pointer device type.</returns>
    public extern PointerDeviceType PointerDeviceType { [MethodImpl] get; }

    /// <summary>Gets a value indicating whether the pointer device is an integrated device. For example, a video display with an integrated touch digitizer compared to an external pen/stylus digitizer.</summary>
    /// <returns>True if the pointer device is integrated; otherwise, false.</returns>
    public extern bool IsIntegrated { [MethodImpl] get; }

    /// <summary>Gets a value indicating the maximum number of contacts supported by the input device.</summary>
    /// <returns>The number of contacts.</returns>
    public extern uint MaxContacts { [MethodImpl] get; }

    /// <summary>Gets the coordinates of the bounding rectangle supported by the input device.</summary>
    /// <returns>The bounding rectangle at 96 dots per inch (dpi).</returns>
    public extern Rect PhysicalDeviceRect { [MethodImpl] get; }

    /// <summary>Gets the screen coordinates that are mapped to the bounding rectangle supported by the input device.</summary>
    /// <returns>The screen coordinates, in device-independent pixel (DIP).</returns>
    public extern Rect ScreenRect { [MethodImpl] get; }

    /// <summary>Gets a collection containing the supported pointer device usages.</summary>
    /// <returns>A collection containing the supported pointer device usages.</returns>
    public extern IVectorView<PointerDeviceUsage> SupportedUsages { [MethodImpl] get; }

    /// <summary>Gets the maximum number of hover contacts supported by the input device.</summary>
    /// <returns>The default value is 0.</returns>
    public extern uint MaxPointersWithZDistance { [MethodImpl] get; }

    /// <summary>Gets information about the pointer device associated with the specified input pointer ID.</summary>
    /// <param name="pointerId">The ID of the pointer input.</param>
    /// <returns>The PointerDevice object that represents the associated pointer device.</returns>
    [MethodImpl]
    public static extern PointerDevice GetPointerDevice(uint pointerId);

    /// <summary>Gets information about the pointer devices attached to the system.</summary>
    /// <returns>The collection of PointerDevice objects that represent the pointer devices attached to the system.</returns>
    [MethodImpl]
    public static extern IVectorView<PointerDevice> GetPointerDevices();
  }
}
