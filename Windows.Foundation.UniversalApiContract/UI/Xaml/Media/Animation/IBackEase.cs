// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Media.Animation.IBackEase
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Media.Animation
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(3833042663, 63493, 19087, 129, 201, 56, 230, 71, 44, 170, 148)]
  [ExclusiveTo(typeof (BackEase))]
  [WebHostHidden]
  internal interface IBackEase
  {
    double Amplitude { get; set; }
  }
}
