// Decompiled with JetBrains decompiler
// Type: Windows.Networking.PushNotifications.RawNotification
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
using Windows.Storage.Streams;

namespace Windows.Networking.PushNotifications
{
  /// <summary>Encapsulates the app-defined content of a raw notification (a push notification that does not involve UI). Its contents can be used in an app's background task, if the app has that capability, or otherwise consumed by the app and acted on as needed.</summary>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [MarshalingBehavior(MarshalingType.Agile)]
  public sealed class RawNotification : IRawNotification, IRawNotification2, IRawNotification3
  {
    /// <summary>Gets the content of the raw notification as a string. This string specifies a background task associated with the app.</summary>
    /// <returns>A string that contains the app-defined notification content, as set by the app server.</returns>
    public extern string Content { [MethodImpl] get; }

    /// <summary>Gets the raw header content from the notification.</summary>
    /// <returns>A map view of the header values. See remarks for the header format.</returns>
    public extern IMapView<string, string> Headers { [MethodImpl] get; }

    /// <summary>Gets the Channel ID of the raw notification.</summary>
    /// <returns>A string that contains the app-defined Channel ID, as set by the app server.</returns>
    public extern string ChannelId { [MethodImpl] get; }

    /// <summary>Gets the content of the raw notification as an IBuffer.</summary>
    /// <returns>An IBuffer representing the content of the raw notification.</returns>
    public extern IBuffer ContentBytes { [MethodImpl] get; }
  }
}
