// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Automation.WindowVisualState
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Automation
{
  /// <summary>Contains values that specify the visual state of a window for the IWindowProvider pattern.</summary>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [WebHostHidden]
  public enum WindowVisualState
  {
    /// <summary>Specifies that the window is normal (restored).</summary>
    Normal,
    /// <summary>Specifies that the window is maximized.</summary>
    Maximized,
    /// <summary>Specifies that the window is minimized.</summary>
    Minimized,
  }
}
