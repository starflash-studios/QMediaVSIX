// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.Primitives.IScrollBarStatics
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Controls.Primitives
{
  [Guid(1173025677, 47124, 18639, 151, 242, 83, 158, 177, 109, 253, 77)]
  [WebHostHidden]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (ScrollBar))]
  internal interface IScrollBarStatics
  {
    DependencyProperty OrientationProperty { get; }

    DependencyProperty ViewportSizeProperty { get; }

    DependencyProperty IndicatorModeProperty { get; }
  }
}
