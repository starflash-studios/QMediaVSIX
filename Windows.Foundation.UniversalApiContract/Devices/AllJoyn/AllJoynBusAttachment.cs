// Decompiled with JetBrains decompiler
// Type: Windows.Devices.AllJoyn.AllJoynBusAttachment
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Devices.Enumeration;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
using Windows.Globalization;

namespace Windows.Devices.AllJoyn
{
  /// <summary>Represents a connection to the underlying communication pipeline (transport agnostic) that AllJoyn uses to communicate with other endpoints regardless of the transport.</summary>
  [Deprecated("AllJoynBusAttachment has been deprecated.  For more info, see MSDN.", DeprecationType.Deprecate, 786432, "Windows.Foundation.UniversalApiContract")]
  [Activatable(typeof (IAllJoynBusAttachmentFactory), 65536, "Windows.Foundation.UniversalApiContract")]
  [MarshalingBehavior(MarshalingType.Agile)]
  [DualApiPartition(version = 167772160)]
  [Activatable(65536, "Windows.Foundation.UniversalApiContract")]
  [Static(typeof (IAllJoynBusAttachmentStatics), 196608, "Windows.Foundation.UniversalApiContract")]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public sealed class AllJoynBusAttachment : IAllJoynBusAttachment, IAllJoynBusAttachment2
  {
    /// <summary>Generates an AllJoynBusAttachment object using the provided connection specification.</summary>
    /// <param name="connectionSpecification">Specification used to initiate and maintain connections to a router node (bus). Windows 10 supports the 'npipe:' transport, formatted according to the .</param>
    [Deprecated("AllJoynBusAttachment has been deprecated.  For more info, see MSDN.", DeprecationType.Deprecate, 786432, "Windows.Foundation.UniversalApiContract")]
    [MethodImpl]
    public extern AllJoynBusAttachment(string connectionSpecification);

    /// <summary>Generates an AllJoynBusAttachment object using the default named pipe connection specification.</summary>
    [MethodImpl]
    public extern AllJoynBusAttachment();

    /// <summary>This property returns an AllJoynAboutData object containing the descriptive data that the platform may advertise on behalf of the app.</summary>
    /// <returns>An object containing descriptive information for an app.</returns>
    public extern AllJoynAboutData AboutData { [Deprecated("AllJoynBusAttachment has been deprecated.  For more info, see MSDN.", DeprecationType.Deprecate, 786432, "Windows.Foundation.UniversalApiContract"), MethodImpl] get; }

    /// <summary>The connection specification used to establish and maintain the bus attachment. If a specification was not provided, this property will retrieve a default named pipe specification.</summary>
    /// <returns>The connection specification.</returns>
    public extern string ConnectionSpecification { [Deprecated("AllJoynBusAttachment has been deprecated.  For more info, see MSDN.", DeprecationType.Deprecate, 786432, "Windows.Foundation.UniversalApiContract"), MethodImpl] get; }

    /// <summary>The current state of the bus attachment. State changes are surfaced via StateChanged events. Possible values are defined by the AllJoynBusAttachmentState enumeration.</summary>
    /// <returns>The state of the bus attachment.</returns>
    public extern AllJoynBusAttachmentState State { [Deprecated("AllJoynBusAttachment has been deprecated.  For more info, see MSDN.", DeprecationType.Deprecate, 786432, "Windows.Foundation.UniversalApiContract"), MethodImpl] get; }

    /// <summary>The unique bus name associated with the remote app. This unique bus name is used to represent it on the bus via the bus attachment.</summary>
    /// <returns>The unique bus name.</returns>
    public extern string UniqueName { [Deprecated("AllJoynBusAttachment has been deprecated.  For more info, see MSDN.", DeprecationType.Deprecate, 786432, "Windows.Foundation.UniversalApiContract"), MethodImpl] get; }

    /// <summary>Pings the specified connection asynchronously.</summary>
    /// <param name="uniqueName">The unique name associated with the connection.</param>
    /// <returns>An AllJoyn status code.</returns>
    [RemoteAsync]
    [Deprecated("AllJoynBusAttachment has been deprecated.  For more info, see MSDN.", DeprecationType.Deprecate, 786432, "Windows.Foundation.UniversalApiContract")]
    [MethodImpl]
    public extern IAsyncOperation<int> PingAsync(string uniqueName);

    /// <summary>Initiates the connection.</summary>
    [Deprecated("AllJoynBusAttachment has been deprecated.  For more info, see MSDN.", DeprecationType.Deprecate, 786432, "Windows.Foundation.UniversalApiContract")]
    [MethodImpl]
    public extern void Connect();

    /// <summary>Initiates a disconnect operation from the router node (bus).</summary>
    [Deprecated("AllJoynBusAttachment has been deprecated.  For more info, see MSDN.", DeprecationType.Deprecate, 786432, "Windows.Foundation.UniversalApiContract")]
    [MethodImpl]
    public extern void Disconnect();

    /// <summary>Occurs when the state of the bus attachment changes. The AllJoynBusAttachmentState enumeration defines the possible state values.</summary>
    public extern event TypedEventHandler<AllJoynBusAttachment, AllJoynBusAttachmentStateChangedEventArgs> StateChanged;

    /// <summary>A list of AllJoynAuthenticationMechanism objects representing the acceptable authentication mechanisms. Default values include Rsa and None.</summary>
    /// <returns>The supported authentication mechanisms.</returns>
    public extern IVector<AllJoynAuthenticationMechanism> AuthenticationMechanisms { [Deprecated("AllJoynBusAttachment has been deprecated.  For more info, see MSDN.", DeprecationType.Deprecate, 786432, "Windows.Foundation.UniversalApiContract"), MethodImpl] get; }

    /// <summary>Occurs when credentials are requested for authentication.</summary>
    public extern event TypedEventHandler<AllJoynBusAttachment, AllJoynCredentialsRequestedEventArgs> CredentialsRequested;

    /// <summary>Occurs when credentials have been provided by a remote Consumer for verification.</summary>
    public extern event TypedEventHandler<AllJoynBusAttachment, AllJoynCredentialsVerificationRequestedEventArgs> CredentialsVerificationRequested;

    /// <summary>Occurs when verification of supplied credentials is complete.</summary>
    public extern event TypedEventHandler<AllJoynBusAttachment, AllJoynAuthenticationCompleteEventArgs> AuthenticationComplete;

    /// <summary>Gets the About data for a specific AllJoyn endpoint. This method is intended to replace the less intuitive static AllJoynAboutDataView.GetDataBySessionPortAsync().</summary>
    /// <param name="serviceInfo">The AllJoyn endpoint from which to retrieve About data.</param>
    /// <returns>
    /// </returns>
    [Overload("GetAboutDataAsync")]
    [RemoteAsync]
    [Deprecated("AllJoynBusAttachment has been deprecated.  For more info, see MSDN.", DeprecationType.Deprecate, 786432, "Windows.Foundation.UniversalApiContract")]
    [MethodImpl]
    public extern IAsyncOperation<AllJoynAboutDataView> GetAboutDataAsync(
      AllJoynServiceInfo serviceInfo);

    /// <summary>Gets the About data for a specific AllJoyn endpoint in a specific language. This method is intended to replace the less intuitive static AllJoynAboutDataView.GetDataBySessionPortAsync().</summary>
    /// <param name="serviceInfo">The AllJoyn endpoint from which to retrieve About data.</param>
    /// <param name="language">The language in which to request About data. If the requested language is not supported, the remote device's default language will be used.</param>
    /// <returns>This method makes acquiring About data more intuitive than it was in previous Windows releases.</returns>
    [Deprecated("AllJoynBusAttachment has been deprecated.  For more info, see MSDN.", DeprecationType.Deprecate, 786432, "Windows.Foundation.UniversalApiContract")]
    [RemoteAsync]
    [Overload("GetAboutDataWithLanguageAsync")]
    [MethodImpl]
    public extern IAsyncOperation<AllJoynAboutDataView> GetAboutDataAsync(
      AllJoynServiceInfo serviceInfo,
      Language language);

    /// <summary>Occurs when a remote AllJoyn endpoint requests to join the bus attachement's session.</summary>
    public extern event TypedEventHandler<AllJoynBusAttachment, AllJoynAcceptSessionJoinerEventArgs> AcceptSessionJoinerRequested;

    /// <summary>Occurs when a remote AllJoyn endpoint joins the session of the bus attachment.</summary>
    public extern event TypedEventHandler<AllJoynBusAttachment, AllJoynSessionJoinedEventArgs> SessionJoined;

    /// <summary>Gets the default AllJoynBusAttachment as defined by the app's manifest.</summary>
    /// <returns>The default bus attachment.</returns>
    [Deprecated("AllJoynBusAttachment has been deprecated.  For more info, see MSDN.", DeprecationType.Deprecate, 786432, "Windows.Foundation.UniversalApiContract")]
    [MethodImpl]
    public static extern AllJoynBusAttachment GetDefault();

    [Deprecated("AllJoynBusAttachment has been deprecated.  For more info, see MSDN.", DeprecationType.Deprecate, 786432, "Windows.Foundation.UniversalApiContract")]
    [MethodImpl]
    public static extern DeviceWatcher GetWatcher(IIterable<string> requiredInterfaces);
  }
}
