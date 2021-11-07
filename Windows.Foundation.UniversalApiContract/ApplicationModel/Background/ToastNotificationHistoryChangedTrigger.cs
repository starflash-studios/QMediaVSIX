// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Background.ToastNotificationHistoryChangedTrigger
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Background
{
  /// <summary>Represents an event that causes a background task to run when the history of toast notifications for the app is cleared, when one or more toast notifications are added to or removed from the notification history for the app, or when one or more toast notifications for the app expire and are removed from the notification history.</summary>
  [Activatable(65536, "Windows.Foundation.UniversalApiContract")]
  [Activatable(typeof (IToastNotificationHistoryChangedTriggerFactory), 65536, "Windows.Foundation.UniversalApiContract")]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Threading(ThreadingModel.MTA)]
  [MarshalingBehavior(MarshalingType.Agile)]
  public sealed class ToastNotificationHistoryChangedTrigger : IBackgroundTrigger
  {
    /// <summary>Creates and initializes a new instance of the ToastNotificationHistoryChangedTrigger class for the app with the specified identifier.</summary>
    /// <param name="applicationId">The identifier of the app for which you want to create an instance of the ToastNotificationHistoryChangedTrigger class.</param>
    [MethodImpl]
    public extern ToastNotificationHistoryChangedTrigger(string applicationId);

    /// <summary>Creates and initializes a new instance of the ToastNotificationHistoryChangedTrigger class.</summary>
    [MethodImpl]
    public extern ToastNotificationHistoryChangedTrigger();
  }
}
