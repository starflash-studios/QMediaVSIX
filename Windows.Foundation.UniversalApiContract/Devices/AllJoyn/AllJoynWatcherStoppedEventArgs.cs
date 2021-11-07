// Decompiled with JetBrains decompiler
// Type: Windows.Devices.AllJoyn.AllJoynWatcherStoppedEventArgs
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.AllJoyn
{
  /// <summary>Contains information about the stopped session watcher object.</summary>
  [DualApiPartition(version = 167772160)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [Activatable(typeof (IAllJoynWatcherStoppedEventArgsFactory), 65536, "Windows.Foundation.UniversalApiContract")]
  [Deprecated("AllJoynWatcherStoppedEventArgs has been deprecated.  For more info, see MSDN.", DeprecationType.Deprecate, 786432, "Windows.Foundation.UniversalApiContract")]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public sealed class AllJoynWatcherStoppedEventArgs : IAllJoynWatcherStoppedEventArgs
  {
    /// <summary>Generates an AllJoynWatcherStoppedEventArgs object that contains status information that identifies the reason the watcher object was stopped.</summary>
    /// <param name="status">The AllJoyn status code.</param>
    [Deprecated("AllJoynWatcherStoppedEventArgs has been deprecated.  For more info, see MSDN.", DeprecationType.Deprecate, 786432, "Windows.Foundation.UniversalApiContract")]
    [MethodImpl]
    public extern AllJoynWatcherStoppedEventArgs(int status);

    /// <summary>Returns a status code that was returned when the watcher object is stopped. This value is represented by AllJoynStatus.</summary>
    /// <returns>The AllJoyn status code.</returns>
    public extern int Status { [Deprecated("AllJoynWatcherStoppedEventArgs has been deprecated.  For more info, see MSDN.", DeprecationType.Deprecate, 786432, "Windows.Foundation.UniversalApiContract"), MethodImpl] get; }
  }
}
