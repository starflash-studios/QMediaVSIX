// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.IGridViewItem
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml.Controls.Primitives;

namespace Windows.UI.Xaml.Controls
{
  [Guid(2107179505, 59329, 20099, 180, 112, 201, 214, 215, 189, 169, 245)]
  [ExclusiveTo(typeof (GridViewItem))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [WebHostHidden]
  internal interface IGridViewItem
  {
    GridViewItemTemplateSettings TemplateSettings { get; }
  }
}
