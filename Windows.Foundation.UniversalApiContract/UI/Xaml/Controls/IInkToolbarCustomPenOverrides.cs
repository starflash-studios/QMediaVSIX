// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.IInkToolbarCustomPenOverrides
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.UI.Input.Inking;
using Windows.UI.Xaml.Media;

namespace Windows.UI.Xaml.Controls
{
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  [ExclusiveTo(typeof (InkToolbarCustomPen))]
  [WebHostHidden]
  [Guid(2636311404, 4693, 16982, 182, 189, 130, 194, 253, 39, 52, 136)]
  internal interface IInkToolbarCustomPenOverrides
  {
    InkDrawingAttributes CreateInkDrawingAttributesCore(
      Brush brush,
      double strokeWidth);
  }
}
