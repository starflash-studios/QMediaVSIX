// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Input.PenDevice
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System;
using System.Runtime.CompilerServices;
using Windows.Devices.Haptics;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.Input
{
  /// <summary>Supports the ability to identify and track connected pen devices.</summary>
  [DualApiPartition(version = 1)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [Static(typeof (IPenDeviceStatics), 524288, "Windows.Foundation.UniversalApiContract")]
  [ContractVersion(typeof (UniversalApiContract), 524288)]
  [Threading(ThreadingModel.Both)]
  public sealed class PenDevice : IPenDevice, IPenDevice2
  {
    /// <summary>Gets the unique identifier of the digital pen represented by the PenDevice object.</summary>
    /// <returns>A **Guid** that uniquely identifies the device.</returns>
    public extern Guid PenId { [MethodImpl] get; }

    public extern SimpleHapticsController SimpleHapticsController { [MethodImpl] get; }

    /// <summary>Obtains a PenDevice object associated with the specified pointer, if available.</summary>
    /// <param name="pointerId">The unique pointer identifier associated with the pointer event.</param>
    /// <returns>A PenDevice object. </returns>
    [MethodImpl]
    public static extern PenDevice GetFromPointerId(uint pointerId);
  }
}
