// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.ScrollBarVisibility
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Controls
{
  /// <summary>Defines constants that specify the visibility of a scrollbar within a ScrollViewer control.</summary>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [WebHostHidden]
  public enum ScrollBarVisibility
  {
    /// <summary>A ScrollBar does not appear even when the viewport cannot display all of the content. Scrolling is disabled.</summary>
    Disabled,
    /// <summary>A ScrollBar appears only when the viewport cannot display all of the content.</summary>
    Auto,
    /// <summary>A ScrollBar does not appear even when the viewport cannot display all of the content. Scrolling is still enabled, and can occur through touch, keyboard, or mouse wheel interaction.</summary>
    Hidden,
    /// <summary>A ScrollBar always appears.</summary>
    Visible,
  }
}
