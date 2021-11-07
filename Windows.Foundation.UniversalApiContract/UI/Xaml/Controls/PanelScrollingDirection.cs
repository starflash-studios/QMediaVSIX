// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.PanelScrollingDirection
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Controls
{
  /// <summary>Defines constants that specify the direction that a panel is scrolling.</summary>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [WebHostHidden]
  public enum PanelScrollingDirection
  {
    /// <summary>The panel is not scrolling.</summary>
    None,
    /// <summary>The panel is scrolling forward.</summary>
    Forward,
    /// <summary>The panel is scrolling backward.</summary>
    Backward,
  }
}
