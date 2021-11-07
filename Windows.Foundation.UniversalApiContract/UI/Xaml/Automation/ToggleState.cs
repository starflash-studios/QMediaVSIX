// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Automation.ToggleState
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Automation
{
  /// <summary>Contains values that specify the ToggleState of a UI Automation element.</summary>
  [WebHostHidden]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public enum ToggleState
  {
    /// <summary>The UI Automation element isn't selected, checked, marked, or otherwise activated.</summary>
    Off,
    /// <summary>The UI Automation element is selected, checked, marked, or otherwise activated.</summary>
    On,
    /// <summary>The UI Automation element is in an indeterminate state.</summary>
    Indeterminate,
  }
}
