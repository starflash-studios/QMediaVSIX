// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Chat.ChatCapabilitiesManager
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Chat
{
  /// <summary>Provides functionality for getting chat capabilities.</summary>
  [Threading(ThreadingModel.Both)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Static(typeof (IChatCapabilitiesManagerStatics), 65536, "Windows.Foundation.UniversalApiContract")]
  [MarshalingBehavior(MarshalingType.Agile)]
  [Static(typeof (IChatCapabilitiesManagerStatics2), 458752, "Windows.Foundation.UniversalApiContract")]
  public static class ChatCapabilitiesManager
  {
    /// <summary>Asynchronously gets the locally cached Rich Communication Services (RCS) chat capabilities for the specified phone number through the specified RcsTransport TransportId.</summary>
    /// <param name="address">The phone number for which to get the Rich Communication Services (RCS) chat capabilities</param>
    /// <param name="transportId">The specific transport ID to use to get the Rich Communication Services (RCS) chat capabilities</param>
    /// <returns>The locally cached Rich Communication Services (RCS) chat capabilities.</returns>
    [RemoteAsync]
    [Overload("GetCachedCapabilitiesForTransportAsync")]
    [MethodImpl]
    public static extern IAsyncOperation<ChatCapabilities> GetCachedCapabilitiesAsync(
      string address,
      string transportId);

    /// <summary>Asynchronously gets the Rich Communication Services (RCS) chat capabilities for the specified phone number through the specified RcsTransport TransportId from the service provider.</summary>
    /// <param name="address">The phone number for which to get the Rich Communication Services (RCS) chat capabilities.</param>
    /// <param name="transportId">The specific transport ID to use to get the Rich Communication Services (RCS) chat capabilities.</param>
    /// <returns>The Rich Communication Services (RCS) chat capabilities from the service provider.</returns>
    [RemoteAsync]
    [Overload("GetCapabilitiesFromNetworkForTransportAsync")]
    [MethodImpl]
    public static extern IAsyncOperation<ChatCapabilities> GetCapabilitiesFromNetworkAsync(
      string address,
      string transportId);

    /// <summary>Asynchronously gets the locally cached Rich Communication Services (RCS) chat capabilities for the specified phone number.</summary>
    /// <param name="address">The phone number for which to get the Rich Communication Services (RCS) chat capabilities</param>
    /// <returns>The locally cached Rich Communication Services (RCS) chat capabilities.</returns>
    [Overload("GetCachedCapabilitiesAsync")]
    [RemoteAsync]
    [MethodImpl]
    public static extern IAsyncOperation<ChatCapabilities> GetCachedCapabilitiesAsync(
      string address);

    /// <summary>Asynchronously gets the Rich Communication Services (RCS) chat capabilities for the specified phone number from the service provider.</summary>
    /// <param name="address">The phone number for which to get the Rich Communication Services (RCS) chat capabilities.</param>
    /// <returns>The Rich Communication Services (RCS) chat capabilities from the service provider.</returns>
    [RemoteAsync]
    [Overload("GetCapabilitiesFromNetworkAsync")]
    [MethodImpl]
    public static extern IAsyncOperation<ChatCapabilities> GetCapabilitiesFromNetworkAsync(
      string address);
  }
}
