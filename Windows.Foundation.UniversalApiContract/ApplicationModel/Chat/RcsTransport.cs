// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Chat.RcsTransport
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Chat
{
  /// <summary>Provides functionality for accessing the Rich Communication Services (RCS) transport.</summary>
  [Threading(ThreadingModel.Both)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public sealed class RcsTransport : IRcsTransport
  {
    /// <summary>Gets a name-value pair for extensibility of service provider configuration values.</summary>
    /// <returns>A name-value pair for extensibility of service provider configuration values.</returns>
    public extern IMapView<string, object> ExtendedProperties { [MethodImpl] get; }

    /// <summary>Gets a Boolean value indicating if the transport is active.</summary>
    /// <returns>A Boolean value indicating if the transport is active.</returns>
    public extern bool IsActive { [MethodImpl] get; }

    /// <summary>Gets the friendly name of the transport.</summary>
    /// <returns>The friendly name of the transport.</returns>
    public extern string TransportFriendlyName { [MethodImpl] get; }

    /// <summary>Gets the ID for the transport that is unique on the device.</summary>
    /// <returns>The ID for the transport that is unique on the device.</returns>
    public extern string TransportId { [MethodImpl] get; }

    /// <summary>Gets a configuration object that describes the transport settings.</summary>
    /// <returns>A configuration object that describes the transport settings.</returns>
    public extern RcsTransportConfiguration Configuration { [MethodImpl] get; }

    /// <summary>Gets a Boolean value indicating if the specified service kind supports store and forward functionality.</summary>
    /// <param name="serviceKind">The service kind to check for store and forward functionality.</param>
    /// <returns>A Boolean value indicating if the *serviceKind * supports store and forward.</returns>
    [MethodImpl]
    public extern bool IsStoreAndForwardEnabled(RcsServiceKind serviceKind);

    /// <summary>Gets a Boolean value indicating if the specified service kind is supported, such as chat, group chat, file transfer, and so on.</summary>
    /// <param name="serviceKind">The service kind to verify.</param>
    /// <returns>TRUE if the RcsServiceKind specified in the *serviceKind* parameter is supported.</returns>
    [MethodImpl]
    public extern bool IsServiceKindSupported(RcsServiceKind serviceKind);

    /// <summary>Occurs when the service capabilities change.</summary>
    public extern event TypedEventHandler<RcsTransport, RcsServiceKindSupportedChangedEventArgs> ServiceKindSupportedChanged;
  }
}
