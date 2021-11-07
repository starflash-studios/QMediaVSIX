// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Media.ISolidColorBrushStatics
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml.Media.Animation;

namespace Windows.UI.Xaml.Media
{
  [ExclusiveTo(typeof (SolidColorBrush))]
  [Guid(3785776890, 11043, 16826, 185, 186, 112, 148, 236, 142, 78, 159)]
  [WebHostHidden]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface ISolidColorBrushStatics
  {
    [IndependentlyAnimatable]
    DependencyProperty ColorProperty { [IndependentlyAnimatable] get; }
  }
}
