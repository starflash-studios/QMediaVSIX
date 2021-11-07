// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.IListViewBase5
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Controls
{
  [WebHostHidden]
  [ExclusiveTo(typeof (ListViewBase))]
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  [Guid(446459545, 5913, 19328, 179, 53, 98, 131, 49, 160, 112, 25)]
  internal interface IListViewBase5
  {
    bool SingleSelectionFollowsFocus { get; set; }

    bool IsDragSource();
  }
}
