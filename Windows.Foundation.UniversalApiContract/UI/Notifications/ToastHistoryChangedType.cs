// Decompiled with JetBrains decompiler
// Type: Windows.UI.Notifications.ToastHistoryChangedType
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Notifications
{
  /// <summary>Specifies the kind of change that has happened to a notification in toast history. Used with ToastNotificationHistoryChangedTriggerDetail.ChangeType.</summary>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public enum ToastHistoryChangedType
  {
    /// <summary>One or more notifications were removed with a clear command.</summary>
    Cleared,
    /// <summary>Just this notification was removed with a remove command.</summary>
    Removed,
    /// <summary>The notification has expired.</summary>
    Expired,
    /// <summary>The notification was added.</summary>
    Added,
  }
}
