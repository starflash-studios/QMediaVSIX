// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Media.Animation.IPowerEase
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Media.Animation
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (PowerEase))]
  [WebHostHidden]
  [Guid(1774716281, 61151, 16475, 134, 128, 217, 96, 104, 128, 201, 55)]
  internal interface IPowerEase
  {
    double Power { get; set; }
  }
}
