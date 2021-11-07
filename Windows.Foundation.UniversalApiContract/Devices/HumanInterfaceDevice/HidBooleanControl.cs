// Decompiled with JetBrains decompiler
// Type: Windows.Devices.HumanInterfaceDevice.HidBooleanControl
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.HumanInterfaceDevice
{
  /// <summary>Represents a simple Boolean control on a HID device that returns on/off values. An example would be the LED light on a keyboard.</summary>
  [MarshalingBehavior(MarshalingType.Agile)]
  [DualApiPartition(version = 100859904)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public sealed class HidBooleanControl : IHidBooleanControl
  {
    /// <summary>Gets the identifier for a given Boolean control.</summary>
    /// <returns>The control identifier.</returns>
    public extern uint Id { [MethodImpl] get; }

    /// <summary>Gets the usage page for a given Boolean control.</summary>
    /// <returns>The usage page.</returns>
    public extern ushort UsagePage { [MethodImpl] get; }

    /// <summary>Gets the usage identifier associated with the given Boolean control.</summary>
    /// <returns>The usage identifier.</returns>
    public extern ushort UsageId { [MethodImpl] get; }

    /// <summary>Gets a Boolean value indicating whether the given Boolean control is active.</summary>
    /// <returns>True, if the control is active; otherwise, false.</returns>
    public extern bool IsActive { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets a description of the given Boolean control.</summary>
    /// <returns>A **HidBooleanControlDescription** object.</returns>
    public extern HidBooleanControlDescription ControlDescription { [MethodImpl] get; }
  }
}
