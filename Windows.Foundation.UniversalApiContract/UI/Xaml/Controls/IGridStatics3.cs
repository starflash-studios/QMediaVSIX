// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.IGridStatics3
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Controls
{
  [ExclusiveTo(typeof (Grid))]
  [WebHostHidden]
  [Guid(3288048695, 23052, 16506, 150, 33, 121, 84, 83, 134, 216, 17)]
  [ContractVersion(typeof (UniversalApiContract), 327680)]
  internal interface IGridStatics3
  {
    DependencyProperty RowSpacingProperty { get; }

    DependencyProperty ColumnSpacingProperty { get; }
  }
}
