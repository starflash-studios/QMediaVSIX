// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.ITreeViewItemTemplateSettingsStatics
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Controls
{
  [Guid(1439113384, 28909, 19489, 147, 244, 45, 121, 193, 164, 165, 247)]
  [WebHostHidden]
  [ContractVersion(typeof (UniversalApiContract), 393216)]
  [ExclusiveTo(typeof (TreeViewItemTemplateSettings))]
  internal interface ITreeViewItemTemplateSettingsStatics
  {
    DependencyProperty ExpandedGlyphVisibilityProperty { get; }

    DependencyProperty CollapsedGlyphVisibilityProperty { get; }

    DependencyProperty IndentationProperty { get; }

    DependencyProperty DragItemsCountProperty { get; }
  }
}
