// Decompiled with JetBrains decompiler
// Type: Windows.Devices.AllJoyn.AllJoynSession
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.AllJoyn
{
  /// <summary>Represents an AllJoyn session created with a provider to consume the services available from that provider.</summary>
  [Static(typeof (IAllJoynSessionStatics), 196608, "Windows.Foundation.UniversalApiContract")]
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [Deprecated("AllJoynSession has been deprecated.  For more info, see MSDN.", DeprecationType.Deprecate, 786432, "Windows.Foundation.UniversalApiContract")]
  [DualApiPartition(version = 167772160)]
  public sealed class AllJoynSession : IAllJoynSession
  {
    /// <summary>Gets the unique ID of the session.</summary>
    /// <returns>The ID.</returns>
    public extern int Id { [Deprecated("AllJoynSession has been deprecated.  For more info, see MSDN.", DeprecationType.Deprecate, 786432, "Windows.Foundation.UniversalApiContract"), MethodImpl] get; }

    /// <summary>Gets the current status of the session.</summary>
    /// <returns>Value representing the status of the session.</returns>
    public extern int Status { [Deprecated("AllJoynSession has been deprecated.  For more info, see MSDN.", DeprecationType.Deprecate, 786432, "Windows.Foundation.UniversalApiContract"), MethodImpl] get; }

    /// <summary>Removes the member specified by the input String from the session.</summary>
    /// <param name="uniqueName">Name of member to be removed from the session.</param>
    /// <returns>An AllJoyn status code.</returns>
    [Deprecated("AllJoynSession has been deprecated.  For more info, see MSDN.", DeprecationType.Deprecate, 786432, "Windows.Foundation.UniversalApiContract")]
    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperation<int> RemoveMemberAsync(string uniqueName);

    /// <summary>Event triggered when a member has been added to an AllJoynSession.</summary>
    public extern event TypedEventHandler<AllJoynSession, AllJoynSessionMemberAddedEventArgs> MemberAdded;

    /// <summary>Event triggered when a member has been removed from an AllJoynSession.</summary>
    public extern event TypedEventHandler<AllJoynSession, AllJoynSessionMemberRemovedEventArgs> MemberRemoved;

    /// <summary>Event triggered when an AllJoynSession has been lost. More information about the event can be found in the associated AllJoynSessionLostEventArgs.</summary>
    public extern event TypedEventHandler<AllJoynSession, AllJoynSessionLostEventArgs> Lost;

    /// <summary>Gets a session with the producer based on the specified service info.</summary>
    /// <param name="serviceInfo">The service info to acquire the correct session.</param>
    /// <returns>An AllJoyn object for the AllJoyn session based off the service info.</returns>
    [RemoteAsync]
    [Deprecated("AllJoynSession has been deprecated.  For more info, see MSDN.", DeprecationType.Deprecate, 786432, "Windows.Foundation.UniversalApiContract")]
    [Overload("GetFromServiceInfoAsync")]
    [MethodImpl]
    public static extern IAsyncOperation<AllJoynSession> GetFromServiceInfoAsync(
      AllJoynServiceInfo serviceInfo);

    /// <summary>Gets a session with the producer based on the specified service info and bus attachment.</summary>
    /// <param name="serviceInfo">The service info to acquire the correct session.</param>
    /// <param name="busAttachment">The bus attachment to identify the AllJoyn session. If not specified, it is set to the result of AllJoynBusAttachment.GetDefault.</param>
    /// <returns>An AllJoyn object for the AllJoyn session based off the service info.</returns>
    [Deprecated("AllJoynSession has been deprecated.  For more info, see MSDN.", DeprecationType.Deprecate, 786432, "Windows.Foundation.UniversalApiContract")]
    [Overload("GetFromServiceInfoAndBusAttachmentAsync")]
    [RemoteAsync]
    [MethodImpl]
    public static extern IAsyncOperation<AllJoynSession> GetFromServiceInfoAsync(
      AllJoynServiceInfo serviceInfo,
      AllJoynBusAttachment busAttachment);
  }
}
