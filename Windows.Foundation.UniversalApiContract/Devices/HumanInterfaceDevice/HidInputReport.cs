// Decompiled with JetBrains decompiler
// Type: Windows.Devices.HumanInterfaceDevice.HidInputReport
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
using Windows.Storage.Streams;

namespace Windows.Devices.HumanInterfaceDevice
{
  /// <summary>Represents a HID Input Report.</summary>
  [DualApiPartition(version = 100859904)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public sealed class HidInputReport : IHidInputReport
  {
    /// <summary>Gets the identifier associated with a given input report.</summary>
    /// <returns>The input report identifier.</returns>
    public extern ushort Id { [MethodImpl] get; }

    /// <summary>Gets the data associated with a given input report.</summary>
    /// <returns>The input-report data.</returns>
    public extern IBuffer Data { [MethodImpl] get; }

    /// <summary>Gets the currently activated Boolean controls for the given HID device.</summary>
    /// <returns>A collection of Boolean controls.</returns>
    public extern IVectorView<HidBooleanControl> ActivatedBooleanControls { [MethodImpl] get; }

    /// <summary>Gets the recently transitioned Boolean controls for the given HID device.</summary>
    /// <returns>A collection of Boolean controls.</returns>
    public extern IVectorView<HidBooleanControl> TransitionedBooleanControls { [MethodImpl] get; }

    /// <summary>Retrieves the Boolean control associated with the *usagePage* and *usageId* parameter and found in the given input report.</summary>
    /// <param name="usagePage">The usage page of the top-level collection for the given HID device.</param>
    /// <param name="usageId">The usage identifier of the top-level collection for the given HID device.</param>
    /// <returns>A **HidBooleanControl** object.</returns>
    [MethodImpl]
    public extern HidBooleanControl GetBooleanControl(
      ushort usagePage,
      ushort usageId);

    /// <summary>Retrieves the Boolean control described by the *controlDescription* parameter and found in the given input report.</summary>
    /// <param name="controlDescription">A **HidBooleanControlDescription** object.</param>
    /// <returns>A **HidBooleanControl** object.</returns>
    [MethodImpl]
    public extern HidBooleanControl GetBooleanControlByDescription(
      HidBooleanControlDescription controlDescription);

    /// <summary>Retrieves the numeric control associated with the *usagePage* and *usageId* parameters and found in the given input report.</summary>
    /// <param name="usagePage">The usage page of the top-level collection for the given HID device.</param>
    /// <param name="usageId">The usage identifier of the top-level collection for the given HID device.</param>
    /// <returns>A **HidNumericControl** object.</returns>
    [MethodImpl]
    public extern HidNumericControl GetNumericControl(
      ushort usagePage,
      ushort usageId);

    /// <summary>Retrieves the numeric control described by the *controlDescription* parameter and found in the given input report.</summary>
    /// <param name="controlDescription">A **HidNumericControlDescription** object.</param>
    /// <returns>A **HidNumericControl** object.</returns>
    [MethodImpl]
    public extern HidNumericControl GetNumericControlByDescription(
      HidNumericControlDescription controlDescription);
  }
}
