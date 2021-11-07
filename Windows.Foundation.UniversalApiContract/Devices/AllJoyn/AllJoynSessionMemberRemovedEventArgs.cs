// Decompiled with JetBrains decompiler
// Type: Windows.Devices.AllJoyn.AllJoynSessionMemberRemovedEventArgs
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.AllJoyn
{
  /// <summary>Contains information about a remote app removed from a session.</summary>
  [MarshalingBehavior(MarshalingType.Agile)]
  [Deprecated("AllJoynSessionMemberRemovedEventArgs has been deprecated.  For more info, see MSDN.", DeprecationType.Deprecate, 786432, "Windows.Foundation.UniversalApiContract")]
  [DualApiPartition(version = 167772160)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Activatable(typeof (IAllJoynSessionMemberRemovedEventArgsFactory), 65536, "Windows.Foundation.UniversalApiContract")]
  public sealed class AllJoynSessionMemberRemovedEventArgs : IAllJoynSessionMemberRemovedEventArgs
  {
    /// <summary>Generates an object containing information about a remote app removed from a session.</summary>
    /// <param name="uniqueName">The unique bus name of the remote app removed from the session.</param>
    [Deprecated("AllJoynSessionMemberRemovedEventArgs has been deprecated.  For more info, see MSDN.", DeprecationType.Deprecate, 786432, "Windows.Foundation.UniversalApiContract")]
    [MethodImpl]
    public extern AllJoynSessionMemberRemovedEventArgs(string uniqueName);

    /// <summary>The unique bus name of the remote app removed from the session.</summary>
    /// <returns>The unique bus name.</returns>
    public extern string UniqueName { [Deprecated("AllJoynSessionMemberRemovedEventArgs has been deprecated.  For more info, see MSDN.", DeprecationType.Deprecate, 786432, "Windows.Foundation.UniversalApiContract"), MethodImpl] get; }
  }
}
