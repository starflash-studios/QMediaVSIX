// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.IColumnDefinition
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Controls
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(4159812137, 61476, 18047, 151, 10, 126, 112, 86, 21, 219, 123)]
  [WebHostHidden]
  [ExclusiveTo(typeof (ColumnDefinition))]
  internal interface IColumnDefinition
  {
    GridLength Width { get; set; }

    double MaxWidth { get; set; }

    double MinWidth { get; set; }

    double ActualWidth { get; }
  }
}
