// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.IGrid3
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Controls
{
  [ExclusiveTo(typeof (Grid))]
  [ContractVersion(typeof (UniversalApiContract), 327680)]
  [Guid(316655100, 9026, 19922, 158, 125, 32, 144, 161, 113, 209, 239)]
  [WebHostHidden]
  internal interface IGrid3
  {
    double RowSpacing { get; set; }

    double ColumnSpacing { get; set; }
  }
}
