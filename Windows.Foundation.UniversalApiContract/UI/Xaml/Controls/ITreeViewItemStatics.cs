// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.ITreeViewItemStatics
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Controls
{
  [Guid(1130862014, 29590, 18140, 162, 100, 33, 197, 101, 129, 197, 229)]
  [ContractVersion(typeof (UniversalApiContract), 393216)]
  [WebHostHidden]
  [ExclusiveTo(typeof (TreeViewItem))]
  internal interface ITreeViewItemStatics
  {
    DependencyProperty GlyphOpacityProperty { get; }

    DependencyProperty GlyphBrushProperty { get; }

    DependencyProperty ExpandedGlyphProperty { get; }

    DependencyProperty CollapsedGlyphProperty { get; }

    DependencyProperty GlyphSizeProperty { get; }

    DependencyProperty IsExpandedProperty { get; }

    DependencyProperty TreeViewItemTemplateSettingsProperty { get; }
  }
}
