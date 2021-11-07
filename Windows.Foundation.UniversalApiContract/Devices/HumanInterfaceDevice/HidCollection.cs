// Decompiled with JetBrains decompiler
// Type: Windows.Devices.HumanInterfaceDevice.HidCollection
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.HumanInterfaceDevice
{
  /// <summary>Retrieves the collection information for a group of related controls.</summary>
  [MarshalingBehavior(MarshalingType.Agile)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [DualApiPartition(version = 100859904)]
  public sealed class HidCollection : IHidCollection
  {
    /// <summary>Gets the identifier for a collection of HID controls.</summary>
    /// <returns>The collection identifier.</returns>
    public extern uint Id { [MethodImpl] get; }

    /// <summary>Gets the collection type.</summary>
    /// <returns>A **HidCollectionType** object.</returns>
    public extern HidCollectionType Type { [MethodImpl] get; }

    /// <summary>Gets the usage page for the given control collection.</summary>
    /// <returns>The usage page.</returns>
    public extern uint UsagePage { [MethodImpl] get; }

    /// <summary>Gets the usage identifier for the given control collection.</summary>
    /// <returns>The usage identifier.</returns>
    public extern uint UsageId { [MethodImpl] get; }
  }
}
