// Decompiled with JetBrains decompiler
// Type: Windows.Devices.HumanInterfaceDevice.HidNumericControlDescription
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.Devices.HumanInterfaceDevice
{
  /// <summary>Describes a numeric control for a given HID device.</summary>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [DualApiPartition(version = 100859904)]
  [MarshalingBehavior(MarshalingType.Agile)]
  public sealed class HidNumericControlDescription : IHidNumericControlDescription
  {
    /// <summary>Gets the identifier for a given numeric control.</summary>
    /// <returns>Identifies the control.</returns>
    public extern uint Id { [MethodImpl] get; }

    /// <summary>Gets the report ID of the HID report that contains the usage or usage range for the given numeric control.</summary>
    /// <returns>The report identifier.</returns>
    public extern ushort ReportId { [MethodImpl] get; }

    /// <summary>Gets the type of HID report associated with the given numeric control.</summary>
    /// <returns>One of the report types: HidFeatureReport, HidInputReport, or HidOutputReport.</returns>
    public extern HidReportType ReportType { [MethodImpl] get; }

    /// <summary>Gets the size of the data field for the usage in a report.</summary>
    /// <returns>The data field size (in bits).</returns>
    public extern uint ReportSize { [MethodImpl] get; }

    /// <summary>Gets the number of reports associated with the given control.</summary>
    /// <returns>The number of reports.</returns>
    public extern uint ReportCount { [MethodImpl] get; }

    /// <summary>Gets the usage page associated with the given numeric control.</summary>
    /// <returns>The usage page.</returns>
    public extern ushort UsagePage { [MethodImpl] get; }

    /// <summary>Gets the usage identifier associated with the given numeric control.</summary>
    /// <returns>The usage identifierl.</returns>
    public extern ushort UsageId { [MethodImpl] get; }

    /// <summary>Gets the lowest possible value for the given control.</summary>
    /// <returns>The signed lower bound.</returns>
    public extern int LogicalMinimum { [MethodImpl] get; }

    /// <summary>Gets the highest possible value for the given control.</summary>
    /// <returns>The signed upper bound.</returns>
    public extern int LogicalMaximum { [MethodImpl] get; }

    /// <summary>Gets the lowest possible value for the given control after scaling is applied to the LogicalMinimum value.</summary>
    /// <returns>The signed lower bound.</returns>
    public extern int PhysicalMinimum { [MethodImpl] get; }

    /// <summary>Gets the highest possible value for the given control after scaling is applied to the LogicalMaximum  value.</summary>
    /// <returns>The signed upper bound.</returns>
    public extern int PhysicalMaximum { [MethodImpl] get; }

    /// <summary>Gets the unit exponent for the given numeric control.</summary>
    /// <returns>The unit exponent.</returns>
    public extern uint UnitExponent { [MethodImpl] get; }

    /// <summary>Specifies the units of the usage, as described by the USB HID Standard.</summary>
    /// <returns>The usage unit.</returns>
    public extern uint Unit { [MethodImpl] get; }

    /// <summary>Gets a value indicating whether the given numeric control values are absolute or relative (change in value from that previously reported).</summary>
    /// <returns>True, if the values are absolute; false if the values are relative.</returns>
    public extern bool IsAbsolute { [MethodImpl] get; }

    /// <summary>Gets a Boolean value which indicates whether the control supports a null, or out-of-range, value.</summary>
    /// <returns>True, if the control supports a null value; otherwise, false.</returns>
    public extern bool HasNull { [MethodImpl] get; }

    /// <summary>Gets the parent collections for a given numeric control.</summary>
    /// <returns>A vector of **HidCollection** objects.</returns>
    public extern IVectorView<HidCollection> ParentCollections { [MethodImpl] get; }
  }
}
