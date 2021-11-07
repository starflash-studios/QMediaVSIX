// Decompiled with JetBrains decompiler
// Type: Windows.UI.Notifications.Notification
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Notifications
{
  /// <summary>Represents a notification.</summary>
  [Threading(ThreadingModel.Both)]
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [Activatable(196608, "Windows.Foundation.UniversalApiContract")]
  public sealed class Notification : INotification
  {
    /// <summary>Creates a new instance of the Notification class.</summary>
    [MethodImpl]
    public extern Notification();

    /// <summary>Gets or sets the notification's expiration.</summary>
    /// <returns>The notification's expiration.</returns>
    public extern IReference<DateTime> ExpirationTime { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets the visual for the notification.</summary>
    /// <returns>The visual for this notification.</returns>
    public extern NotificationVisual Visual { [MethodImpl] get; [MethodImpl] set; }
  }
}
