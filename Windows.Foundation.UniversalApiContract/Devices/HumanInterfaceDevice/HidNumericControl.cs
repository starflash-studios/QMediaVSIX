// Decompiled with JetBrains decompiler
// Type: Windows.Devices.HumanInterfaceDevice.HidNumericControl
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.HumanInterfaceDevice
{
  /// <summary>Represents a numeric control on a HID device that returns a range of values. An example would be the volume control on a speaker.</summary>
  [MarshalingBehavior(MarshalingType.Agile)]
  [DualApiPartition(version = 100859904)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public sealed class HidNumericControl : IHidNumericControl
  {
    /// <summary>Gets the identifier for the given numeric control.</summary>
    /// <returns>The control identifier.</returns>
    public extern uint Id { [MethodImpl] get; }

    /// <summary>Gets a Boolean value that indicates whether the given numeric control is grouped with other, related controls.</summary>
    /// <returns>True, if grouped; otherwise, false.</returns>
    public extern bool IsGrouped { [MethodImpl] get; }

    /// <summary>Gets the usage page for the given numeric control.</summary>
    /// <returns>The usage page.</returns>
    public extern ushort UsagePage { [MethodImpl] get; }

    /// <summary>Gets the usage identifier for the given numeric control.</summary>
    /// <returns>The usage identifier.</returns>
    public extern ushort UsageId { [MethodImpl] get; }

    /// <summary>Gets or sets the numeric value for a given control.</summary>
    /// <returns>The control value.</returns>
    public extern long Value { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets a scaled numeric-value for the given control.</summary>
    /// <returns>The scaled value.</returns>
    public extern long ScaledValue { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets a control description for the given numeric control.</summary>
    /// <returns>A **HidNumericControlDescription** object.</returns>
    public extern HidNumericControlDescription ControlDescription { [MethodImpl] get; }
  }
}
