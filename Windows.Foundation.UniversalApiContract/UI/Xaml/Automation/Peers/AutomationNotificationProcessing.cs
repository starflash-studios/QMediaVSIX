// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Automation.Peers.AutomationNotificationProcessing
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Automation.Peers
{
  /// <summary>Specifies the order in which to process a notification.</summary>
  [WebHostHidden]
  [ContractVersion(typeof (UniversalApiContract), 327680)]
  public enum AutomationNotificationProcessing
  {
    /// <summary>These notifications should be presented to the user as soon as possible. All of the notifications from this source should be delivered to the user.  </summary>
    ImportantAll,
    /// <summary>These notifications should be presented to the user as soon as possible. The most recent notifications from this source should be delivered to the user because the most recent notification supersedes all of the other notifications.</summary>
    ImportantMostRecent,
    /// <summary>These notifications should be presented to the user when possible. All of the notifications from this source should be delivered to the user.</summary>
    All,
    /// <summary>These notifications should be presented to the user when possible. Interrupt the current notification for this one.</summary>
    MostRecent,
    /// <summary>These notifications should be presented to the user when possible. Don’t interrupt the current notification for this one. If new notifications come in from the same source while the current notification is being presented, then keep the most recent and ignore the rest until the current processing is completed. Then use the most recent message as the current message.</summary>
    CurrentThenMostRecent,
  }
}
