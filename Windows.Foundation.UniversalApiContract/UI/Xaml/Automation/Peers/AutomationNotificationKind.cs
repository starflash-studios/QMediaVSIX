// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Automation.Peers.AutomationNotificationKind
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Automation.Peers
{
  /// <summary>Indicates the type of notification when calling RaiseNotificationEvent</summary>
  [WebHostHidden]
  [ContractVersion(typeof (UniversalApiContract), 327680)]
  public enum AutomationNotificationKind
  {
    /// <summary>The current element container has had something added to it that should be presented to the user.</summary>
    ItemAdded,
    /// <summary>The current element has had something removed from inside it that should be presented to the user.</summary>
    ItemRemoved,
    /// <summary>The current element has a notification that an action was completed.</summary>
    ActionCompleted,
    /// <summary>The current element has a notification that an action was abandoned.</summary>
    ActionAborted,
    /// <summary>The current element has a notification not an add, remove, completed, or aborted action.</summary>
    Other,
  }
}
