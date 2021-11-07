// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Automation.Peers.AutomationLiveSetting
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Automation.Peers
{
  /// <summary>Describes the notification characteristics of a particular live region in an app UI. Used by GetLiveSetting and AutomationProperties.LiveSetting.</summary>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [WebHostHidden]
  public enum AutomationLiveSetting
  {
    /// <summary>The element does not send notifications if the content of the live region has changed.</summary>
    Off,
    /// <summary>The element sends non-interruptive notifications if the content of the live region has changed. With this setting, Microsoft UI Automation clients and assistive technology are expected to not interrupt the user to inform of changes to the live region.</summary>
    Polite,
    /// <summary>The element sends interruptive notifications if the content of the live region has changed. With this setting, Microsoft UI Automation clients and assistive technology are expected to interrupt the user to inform of changes to the live region.</summary>
    Assertive,
  }
}
