// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Media.Animation.IExponentialEaseStatics
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Media.Animation
{
  [Guid(4085180387, 42849, 17234, 154, 214, 112, 121, 69, 103, 88, 26)]
  [WebHostHidden]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (ExponentialEase))]
  internal interface IExponentialEaseStatics
  {
    DependencyProperty ExponentProperty { get; }
  }
}
