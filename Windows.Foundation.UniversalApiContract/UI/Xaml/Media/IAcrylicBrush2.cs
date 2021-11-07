// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Media.IAcrylicBrush2
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Media
{
  [Guid(3378795395, 45470, 23232, 134, 255, 61, 144, 80, 109, 188, 218)]
  [ExclusiveTo(typeof (AcrylicBrush))]
  [WebHostHidden]
  [ContractVersion(typeof (UniversalApiContract), 524288)]
  internal interface IAcrylicBrush2
  {
    IReference<double> TintLuminosityOpacity { get; set; }
  }
}
