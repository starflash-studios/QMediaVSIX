// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.ITreeViewItemTemplateSettings
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Controls
{
  [ExclusiveTo(typeof (TreeViewItemTemplateSettings))]
  [ContractVersion(typeof (UniversalApiContract), 393216)]
  [Guid(3962713924, 56881, 18742, 191, 194, 28, 179, 123, 161, 220, 8)]
  [WebHostHidden]
  internal interface ITreeViewItemTemplateSettings
  {
    Visibility ExpandedGlyphVisibility { get; }

    Visibility CollapsedGlyphVisibility { get; }

    Thickness Indentation { get; }

    int DragItemsCount { get; }
  }
}
