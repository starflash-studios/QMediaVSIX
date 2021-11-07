// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.ISliderStatics2
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Controls
{
  [ExclusiveTo(typeof (Slider))]
  [Guid(15176541, 31141, 18265, 150, 166, 41, 224, 169, 74, 221, 51)]
  [WebHostHidden]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface ISliderStatics2
  {
    DependencyProperty HeaderProperty { get; }

    DependencyProperty HeaderTemplateProperty { get; }
  }
}
