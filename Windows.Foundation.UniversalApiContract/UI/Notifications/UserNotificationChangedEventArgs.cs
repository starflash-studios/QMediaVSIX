// Decompiled with JetBrains decompiler
// Type: Windows.UI.Notifications.UserNotificationChangedEventArgs
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Notifications
{
  /// <summary>Provides info when a user notification changes.</summary>
  [MarshalingBehavior(MarshalingType.Agile)]
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  public sealed class UserNotificationChangedEventArgs : IUserNotificationChangedEventArgs
  {
    /// <summary>Gets the type of change this triggered the event.</summary>
    /// <returns>The type of change that triggered the event.</returns>
    public extern UserNotificationChangedKind ChangeKind { [MethodImpl] get; }

    /// <summary>Gets the ID of the user notification that changed.</summary>
    /// <returns>The ID of the user notification that changed.</returns>
    public extern uint UserNotificationId { [MethodImpl] get; }
  }
}
