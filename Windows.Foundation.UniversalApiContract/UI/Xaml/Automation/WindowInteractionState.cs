// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Automation.WindowInteractionState
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Automation
{
  /// <summary>Defines values that specify the current state of the window for purposes of user or programmatic interaction.</summary>
  [WebHostHidden]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public enum WindowInteractionState
  {
    /// <summary>The window is running. This doesn't guarantee that the window is responding or ready for user interaction.</summary>
    Running,
    /// <summary>The window is closing.</summary>
    Closing,
    /// <summary>The window is ready for user interaction.</summary>
    ReadyForUserInteraction,
    /// <summary>The window is blocked by a modal window.</summary>
    BlockedByModalWindow,
    /// <summary>The window is not responding.</summary>
    NotResponding,
  }
}
