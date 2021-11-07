// Decompiled with JetBrains decompiler
// Type: Windows.UI.Notifications.ToastNotificationHistoryChangedTriggerDetail
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Notifications
{
  /// <summary>Represents the details of a toast history changed trigger.</summary>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [MarshalingBehavior(MarshalingType.Standard)]
  public sealed class ToastNotificationHistoryChangedTriggerDetail : 
    IToastNotificationHistoryChangedTriggerDetail,
    IToastNotificationHistoryChangedTriggerDetail2
  {
    /// <summary>Gets a value representing the kind of change that caused the toast history changed trigger.</summary>
    /// <returns>The kind of change that has happened to a notification in toast history.</returns>
    public extern ToastHistoryChangedType ChangeType { [MethodImpl] get; }

    /// <summary>Gets the ID of the notification group to which the notification that caused the change trigger belongs.</summary>
    /// <returns>The ID of the notification group to which the notification that caused the change trigger belongs.</returns>
    public extern string CollectionId { [MethodImpl] get; }
  }
}
