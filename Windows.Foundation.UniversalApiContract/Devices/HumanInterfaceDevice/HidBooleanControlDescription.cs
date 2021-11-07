// Decompiled with JetBrains decompiler
// Type: Windows.Devices.HumanInterfaceDevice.HidBooleanControlDescription
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.Devices.HumanInterfaceDevice
{
  /// <summary>Describes a Boolean control for a given HID device.</summary>
  [DualApiPartition(version = 100859904)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public sealed class HidBooleanControlDescription : 
    IHidBooleanControlDescription,
    IHidBooleanControlDescription2
  {
    /// <summary>Gets the identifier for a given Boolean control.</summary>
    /// <returns>The control identifier.</returns>
    public extern uint Id { [MethodImpl] get; }

    /// <summary>Gets the report ID of the HID report that contains the usage or usage range for the given Boolean control.</summary>
    /// <returns>The report identifier.</returns>
    public extern ushort ReportId { [MethodImpl] get; }

    /// <summary>Gets the type of HID report associated with the given Boolean control.</summary>
    /// <returns>One of the report types: HidFeatureReport, HidInputReport, or HidOutputReport.</returns>
    public extern HidReportType ReportType { [MethodImpl] get; }

    /// <summary>Gets the usage page associated with the given Boolean control.</summary>
    /// <returns>The usage page.</returns>
    public extern ushort UsagePage { [MethodImpl] get; }

    /// <summary>Gets the usage identifier associated with the given Boolean control.</summary>
    /// <returns>The usage identifier.</returns>
    public extern ushort UsageId { [MethodImpl] get; }

    /// <summary>Gets the parent collection for a given Boolean control.</summary>
    /// <returns>The control's parent collection.</returns>
    public extern IVectorView<HidCollection> ParentCollections { [MethodImpl] get; }

    /// <summary>Gets a value indicating whether the given boolean control values are absolute or relative (change in value from that previously reported).</summary>
    /// <returns>True if the values are absolute; false if the values are relative.</returns>
    public extern bool IsAbsolute { [MethodImpl] get; }
  }
}
