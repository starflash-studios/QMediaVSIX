// Decompiled with JetBrains decompiler
// Type: Windows.Devices.AllJoyn.AllJoynBusObjectStoppedEventArgs
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.AllJoyn
{
  /// <summary>Contains information about the stopped AllJoynBusObject.</summary>
  [DualApiPartition(version = 167772160)]
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  [Activatable(typeof (IAllJoynBusObjectStoppedEventArgsFactory), 196608, "Windows.Foundation.UniversalApiContract")]
  [Deprecated("AllJoynBusObjectStoppedEventArgs has been deprecated.  For more info, see MSDN.", DeprecationType.Deprecate, 786432, "Windows.Foundation.UniversalApiContract")]
  [MarshalingBehavior(MarshalingType.Agile)]
  public sealed class AllJoynBusObjectStoppedEventArgs : IAllJoynBusObjectStoppedEventArgs
  {
    /// <summary>Creates an AllJoynBusObjectStoppedEventArgs class used for communicating status of the AllJoynBusObject.Stopped event.</summary>
    /// <param name="status">Value indicating the status.</param>
    [Deprecated("AllJoynBusObjectStoppedEventArgs has been deprecated.  For more info, see MSDN.", DeprecationType.Deprecate, 786432, "Windows.Foundation.UniversalApiContract")]
    [MethodImpl]
    public extern AllJoynBusObjectStoppedEventArgs(int status);

    /// <summary>Gets the status of the AllJoynBusObject that was stopped.</summary>
    /// <returns>The status of the bus object.</returns>
    public extern int Status { [Deprecated("AllJoynBusObjectStoppedEventArgs has been deprecated.  For more info, see MSDN.", DeprecationType.Deprecate, 786432, "Windows.Foundation.UniversalApiContract"), MethodImpl] get; }
  }
}
