// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.IInkToolbarCustomPenButton
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Controls
{
  [WebHostHidden]
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  [Guid(1174553601, 11050, 20284, 165, 60, 26, 4, 90, 64, 142, 250)]
  [ExclusiveTo(typeof (InkToolbarCustomPenButton))]
  internal interface IInkToolbarCustomPenButton
  {
    InkToolbarCustomPen CustomPen { get; set; }

    UIElement ConfigurationContent { get; set; }
  }
}
