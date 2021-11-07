// Decompiled with JetBrains decompiler
// Type: Windows.Devices.AllJoyn.AllJoynAcceptSessionJoinerEventArgs
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.AllJoyn
{
  /// <summary>Contains information about a join session request that is used to determine if the request will be accepted and initiate the session connection.</summary>
  [DualApiPartition(version = 167772160)]
  [Activatable(typeof (IAllJoynAcceptSessionJoinerEventArgsFactory), 65536, "Windows.Foundation.UniversalApiContract")]
  [Deprecated("AllJoynAcceptSessionJoinerEventArgs has been deprecated.  For more info, see MSDN.", DeprecationType.Deprecate, 786432, "Windows.Foundation.UniversalApiContract")]
  [MarshalingBehavior(MarshalingType.Agile)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public sealed class AllJoynAcceptSessionJoinerEventArgs : IAllJoynAcceptSessionJoinerEventArgs
  {
    /// <summary>Generates an object containing information about the connection being accepted to the session and the method that completes the session join.</summary>
    /// <param name="uniqueName">The unique bus name.</param>
    /// <param name="sessionPort">The session port used for the connection.</param>
    /// <param name="trafficType">The type of traffic provided over the connection.</param>
    /// <param name="proximity">Indicates network proximity.</param>
    /// <param name="acceptSessionJoiner">The IAllJoynAcceptSessionJoiner object used to complete the session join.</param>
    [Deprecated("AllJoynAcceptSessionJoinerEventArgs has been deprecated.  For more info, see MSDN.", DeprecationType.Deprecate, 786432, "Windows.Foundation.UniversalApiContract")]
    [MethodImpl]
    public extern AllJoynAcceptSessionJoinerEventArgs(
      string uniqueName,
      ushort sessionPort,
      AllJoynTrafficType trafficType,
      byte proximity,
      IAllJoynAcceptSessionJoiner acceptSessionJoiner);

    /// <summary>The unique bus name of the app requesting a session connection.</summary>
    /// <returns>The unique bus name of the app.</returns>
    public extern string UniqueName { [Deprecated("AllJoynAcceptSessionJoinerEventArgs has been deprecated.  For more info, see MSDN.", DeprecationType.Deprecate, 786432, "Windows.Foundation.UniversalApiContract"), MethodImpl] get; }

    /// <summary>The session port being used to connect to the session.</summary>
    /// <returns>The session port number.</returns>
    public extern ushort SessionPort { [Deprecated("AllJoynAcceptSessionJoinerEventArgs has been deprecated.  For more info, see MSDN.", DeprecationType.Deprecate, 786432, "Windows.Foundation.UniversalApiContract"), MethodImpl] get; }

    /// <summary>The traffic type supported during the session.</summary>
    /// <returns>The traffic type.</returns>
    public extern AllJoynTrafficType TrafficType { [Deprecated("AllJoynAcceptSessionJoinerEventArgs has been deprecated.  For more info, see MSDN.", DeprecationType.Deprecate, 786432, "Windows.Foundation.UniversalApiContract"), MethodImpl] get; }

    /// <summary>The app joining the session is on the same physical node.</summary>
    /// <returns>True if on the same node; otherwise, false.</returns>
    public extern bool SamePhysicalNode { [Deprecated("AllJoynAcceptSessionJoinerEventArgs has been deprecated.  For more info, see MSDN.", DeprecationType.Deprecate, 786432, "Windows.Foundation.UniversalApiContract"), MethodImpl] get; }

    /// <summary>Indicates if the app joining the session is on the same network.</summary>
    /// <returns>True if on the same network; otherwise, false.</returns>
    public extern bool SameNetwork { [Deprecated("AllJoynAcceptSessionJoinerEventArgs has been deprecated.  For more info, see MSDN.", DeprecationType.Deprecate, 786432, "Windows.Foundation.UniversalApiContract"), MethodImpl] get; }

    /// <summary>Called to accept the session connection.</summary>
    [Deprecated("AllJoynAcceptSessionJoinerEventArgs has been deprecated.  For more info, see MSDN.", DeprecationType.Deprecate, 786432, "Windows.Foundation.UniversalApiContract")]
    [MethodImpl]
    public extern void Accept();
  }
}
