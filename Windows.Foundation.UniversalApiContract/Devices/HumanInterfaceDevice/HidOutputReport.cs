// Decompiled with JetBrains decompiler
// Type: Windows.Devices.HumanInterfaceDevice.HidOutputReport
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Storage.Streams;

namespace Windows.Devices.HumanInterfaceDevice
{
  /// <summary>Represents a HID Output Report.</summary>
  [DualApiPartition(version = 100859904)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [MarshalingBehavior(MarshalingType.Agile)]
  public sealed class HidOutputReport : IHidOutputReport
  {
    /// <summary>Gets the identifier associated with a given output report.</summary>
    /// <returns>The output report identifier.</returns>
    public extern ushort Id { [MethodImpl] get; }

    /// <summary>Gets or sets the data associated with a given output report.</summary>
    /// <returns>The output report data.</returns>
    public extern IBuffer Data { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Retrieves the boolean control associated with the given *usagePage* and *usageId*.</summary>
    /// <param name="usagePage">The usage page associated with the given control.</param>
    /// <param name="usageId">The usage identifier associated with the given control.</param>
    /// <returns>A **HidBooleanControl** object.</returns>
    [MethodImpl]
    public extern HidBooleanControl GetBooleanControl(
      ushort usagePage,
      ushort usageId);

    /// <summary>Retrieves the boolean control associated with the given *controlDescription*.</summary>
    /// <param name="controlDescription">Describes the Boolean control.</param>
    /// <returns>A **HidBooleanControl** object.</returns>
    [MethodImpl]
    public extern HidBooleanControl GetBooleanControlByDescription(
      HidBooleanControlDescription controlDescription);

    /// <summary>Retrieves the numeric control associated with the given *usagePage* and *usageId*.</summary>
    /// <param name="usagePage">The usage page associated with the given control.</param>
    /// <param name="usageId">The usage identifier associated with the given control.</param>
    /// <returns>A **HidNumericControl** l object.</returns>
    [MethodImpl]
    public extern HidNumericControl GetNumericControl(
      ushort usagePage,
      ushort usageId);

    /// <summary>Retrieves the numeric control associated with the given *controlDescription*.</summary>
    /// <param name="controlDescription">Describes the numeric control.</param>
    /// <returns>A **HidNumericControl** object.</returns>
    [MethodImpl]
    public extern HidNumericControl GetNumericControlByDescription(
      HidNumericControlDescription controlDescription);
  }
}
