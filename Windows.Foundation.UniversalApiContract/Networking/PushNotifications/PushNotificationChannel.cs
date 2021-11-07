// Decompiled with JetBrains decompiler
// Type: Windows.Networking.PushNotifications.PushNotificationChannel
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Networking.PushNotifications
{
  /// <summary>Represents a delivery vehicle and addressing mechanism for push notifications.</summary>
  [MarshalingBehavior(MarshalingType.Agile)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public sealed class PushNotificationChannel : IPushNotificationChannel
  {
    /// <summary>Gets the Uniform Resource Identifier (URI) to which an app server sends a push notification intended for an application or secondary tile bound to this channel. This Uniform Resource Identifier (URI) is transmitted to and stored by the third-party app server.</summary>
    /// <returns>The Uniform Resource Identifier (URI) (https) that the app server uses to post notifications.</returns>
    public extern string Uri { [MethodImpl] get; }

    /// <summary>Gets the time at which the channel expires. Notifications sent to this channel after this time are rejected.</summary>
    /// <returns>The time at which the channel expires. Notifications sent to this channel after this time are rejected.</returns>
    public extern DateTime ExpirationTime { [MethodImpl] get; }

    /// <summary>Explicitly invalidates this channel. Any notifications pushed to this channel after this method is called are not delivered.</summary>
    [MethodImpl]
    public extern void Close();

    /// <summary>Raised when a push notification arrives on this channel.</summary>
    public extern event TypedEventHandler<PushNotificationChannel, PushNotificationReceivedEventArgs> PushNotificationReceived;
  }
}
