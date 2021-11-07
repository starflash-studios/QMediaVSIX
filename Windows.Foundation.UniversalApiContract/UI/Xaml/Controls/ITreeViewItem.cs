// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.ITreeViewItem
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml.Media;

namespace Windows.UI.Xaml.Controls
{
  [WebHostHidden]
  [ContractVersion(typeof (UniversalApiContract), 393216)]
  [ExclusiveTo(typeof (TreeViewItem))]
  [Guid(1309004774, 24935, 17639, 156, 116, 41, 29, 221, 109, 246, 235)]
  internal interface ITreeViewItem
  {
    double GlyphOpacity { get; set; }

    Brush GlyphBrush { get; set; }

    string ExpandedGlyph { get; set; }

    string CollapsedGlyph { get; set; }

    double GlyphSize { get; set; }

    bool IsExpanded { get; set; }

    TreeViewItemTemplateSettings TreeViewItemTemplateSettings { get; }
  }
}
