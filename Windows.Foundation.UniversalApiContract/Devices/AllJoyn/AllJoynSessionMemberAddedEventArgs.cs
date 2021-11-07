// Decompiled with JetBrains decompiler
// Type: Windows.Devices.AllJoyn.AllJoynSessionMemberAddedEventArgs
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.AllJoyn
{
  /// <summary>Contains information about a peer that was added to a session.</summary>
  [Deprecated("AllJoynSessionMemberAddedEventArgs has been deprecated.  For more info, see MSDN.", DeprecationType.Deprecate, 786432, "Windows.Foundation.UniversalApiContract")]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [DualApiPartition(version = 167772160)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [Activatable(typeof (IAllJoynSessionMemberAddedEventArgsFactory), 65536, "Windows.Foundation.UniversalApiContract")]
  public sealed class AllJoynSessionMemberAddedEventArgs : IAllJoynSessionMemberAddedEventArgs
  {
    /// <summary>Generates an object that contains information about the remote app added to the session.</summary>
    /// <param name="uniqueName">The unique Consumer name.</param>
    [Deprecated("AllJoynSessionMemberAddedEventArgs has been deprecated.  For more info, see MSDN.", DeprecationType.Deprecate, 786432, "Windows.Foundation.UniversalApiContract")]
    [MethodImpl]
    public extern AllJoynSessionMemberAddedEventArgs(string uniqueName);

    /// <summary>The unique bus name of the remote app new to the session.</summary>
    /// <returns>The unique bus name.</returns>
    public extern string UniqueName { [Deprecated("AllJoynSessionMemberAddedEventArgs has been deprecated.  For more info, see MSDN.", DeprecationType.Deprecate, 786432, "Windows.Foundation.UniversalApiContract"), MethodImpl] get; }
  }
}
