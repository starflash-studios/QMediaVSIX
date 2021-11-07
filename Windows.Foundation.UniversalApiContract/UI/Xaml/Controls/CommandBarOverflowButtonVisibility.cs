// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.CommandBarOverflowButtonVisibility
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Controls
{
  /// <summary>Defines constants that specify when a command bar's overflow button is shown.</summary>
  [WebHostHidden]
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  public enum CommandBarOverflowButtonVisibility
  {
    /// <summary>The overflow button automatically hides when there are no secondary commands and the closed state of the CommandBar is the same as the open state.</summary>
    Auto,
    /// <summary>The overflow button is always shown.</summary>
    Visible,
    /// <summary>The overflow button is never shown.</summary>
    Collapsed,
  }
}
