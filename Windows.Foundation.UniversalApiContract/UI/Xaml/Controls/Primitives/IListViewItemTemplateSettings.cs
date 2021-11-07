// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.Primitives.IListViewItemTemplateSettings
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Controls.Primitives
{
  [Guid(1739556031, 33401, 18054, 147, 38, 205, 24, 159, 39, 87, 93)]
  [WebHostHidden]
  [ExclusiveTo(typeof (ListViewItemTemplateSettings))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IListViewItemTemplateSettings
  {
    int DragItemsCount { get; }
  }
}
