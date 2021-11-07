// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.IVariableSizedWrapGrid
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Controls
{
  [Guid(2628061127, 9161, 20225, 184, 15, 190, 92, 33, 238, 244, 116)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (VariableSizedWrapGrid))]
  [WebHostHidden]
  internal interface IVariableSizedWrapGrid
  {
    double ItemHeight { get; set; }

    double ItemWidth { get; set; }

    Orientation Orientation { get; set; }

    HorizontalAlignment HorizontalChildrenAlignment { get; set; }

    VerticalAlignment VerticalChildrenAlignment { get; set; }

    int MaximumRowsOrColumns { get; set; }
  }
}
