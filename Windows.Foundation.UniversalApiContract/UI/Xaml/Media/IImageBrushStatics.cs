// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Media.IImageBrushStatics
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Media
{
  [Guid(307605938, 56600, 17125, 137, 44, 234, 227, 12, 48, 91, 140)]
  [ExclusiveTo(typeof (ImageBrush))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [WebHostHidden]
  internal interface IImageBrushStatics
  {
    DependencyProperty ImageSourceProperty { get; }
  }
}
