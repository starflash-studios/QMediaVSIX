// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Input.PointerDeviceUsage
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.Input
{
  /// <summary>Identifies the Human Interface Device (HID) usage details for the input device.</summary>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public struct PointerDeviceUsage
  {
    /// <summary>The Human Interface Device (HID) usage page of the pointer device. Human Interface Device (HID) usages are organized into usage pages that specify classes of related devices. For example, touch digitizers (0x0D) and generic input (0x01).</summary>
    public uint UsagePage;
    /// <summary>The Human Interface Device (HID) pointer device usage ID that specifies a device or property in the **UsagePage**. For example, 0x04 indicates a touch screen device and 0x47 indicates touch confidence.</summary>
    public uint Usage;
    /// <summary>The minimum logical value for **Usage**.</summary>
    public int MinLogical;
    /// <summary>The maximum logical value for **Usage**.</summary>
    public int MaxLogical;
    /// <summary>The minimum physical value for **Usage**.</summary>
    public int MinPhysical;
    /// <summary>The maximum physical value for **Usage**.</summary>
    public int MaxPhysical;
    /// <summary>The Human Interface Device (HID) unit of measure.</summary>
    public uint Unit;
    /// <summary>The multiplier used to convert the usage value reported by the device to a physical value in units of **Unit**. (Valid only for usages that indicate a static or dynamic value associated with a control, such as pressure or width and height of the touch contact.)</summary>
    public float PhysicalMultiplier;
  }
}
