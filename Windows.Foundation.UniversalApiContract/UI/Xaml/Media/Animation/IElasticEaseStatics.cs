// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Media.Animation.IElasticEaseStatics
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Media.Animation
{
  [ExclusiveTo(typeof (ElasticEase))]
  [Guid(2851432172, 65180, 19243, 142, 82, 187, 120, 93, 86, 33, 133)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [WebHostHidden]
  internal interface IElasticEaseStatics
  {
    DependencyProperty OscillationsProperty { get; }

    DependencyProperty SpringinessProperty { get; }
  }
}
