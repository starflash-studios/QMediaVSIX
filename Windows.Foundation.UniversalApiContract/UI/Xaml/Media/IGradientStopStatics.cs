// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Media.IGradientStopStatics
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Media
{
  [Guid(1613393269, 24979, 20453, 142, 130, 199, 198, 246, 254, 186, 253)]
  [ExclusiveTo(typeof (GradientStop))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [WebHostHidden]
  internal interface IGradientStopStatics
  {
    DependencyProperty ColorProperty { get; }

    DependencyProperty OffsetProperty { get; }
  }
}
