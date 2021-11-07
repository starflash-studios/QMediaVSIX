// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.IWrapGrid
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Controls
{
  [ExclusiveTo(typeof (WrapGrid))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(89266059, 30055, 18370, 189, 92, 173, 131, 148, 200, 40, 186)]
  [WebHostHidden]
  internal interface IWrapGrid
  {
    double ItemWidth { get; set; }

    double ItemHeight { get; set; }

    Orientation Orientation { get; set; }

    HorizontalAlignment HorizontalChildrenAlignment { get; set; }

    VerticalAlignment VerticalChildrenAlignment { get; set; }

    int MaximumRowsOrColumns { get; set; }
  }
}
