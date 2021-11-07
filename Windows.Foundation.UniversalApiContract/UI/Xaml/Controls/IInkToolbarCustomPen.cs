// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.IInkToolbarCustomPen
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
  [Guid(1082269819, 12093, 20074, 140, 39, 254, 97, 239, 126, 112, 235)]
  [ExclusiveTo(typeof (InkToolbarCustomPen))]
  [WebHostHidden]
  internal interface IInkToolbarCustomPen
  {
    InkDrawingAttributes CreateInkDrawingAttributes(
      Brush brush,
      double strokeWidth);
  }
}
