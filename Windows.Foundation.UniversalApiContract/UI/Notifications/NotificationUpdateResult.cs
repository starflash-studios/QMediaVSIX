// Decompiled with JetBrains decompiler
// Type: Windows.UI.Notifications.NotificationUpdateResult
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Notifications
{
  /// <summary>Describes the results of a notification update.</summary>
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  public enum NotificationUpdateResult
  {
    /// <summary>The notification was updated.</summary>
    Succeeded,
    /// <summary>The notification update failed.</summary>
    Failed,
    /// <summary>The specified notification couldn't be found.</summary>
    NotificationNotFound,
  }
}
