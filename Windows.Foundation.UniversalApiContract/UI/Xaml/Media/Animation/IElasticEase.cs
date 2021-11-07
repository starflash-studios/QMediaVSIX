// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Media.Animation.IElasticEase
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Media.Animation
{
  [WebHostHidden]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(4015760780, 45238, 19052, 156, 168, 251, 66, 51, 241, 36, 89)]
  [ExclusiveTo(typeof (ElasticEase))]
  internal interface IElasticEase
  {
    int Oscillations { get; set; }

    double Springiness { get; set; }
  }
}
