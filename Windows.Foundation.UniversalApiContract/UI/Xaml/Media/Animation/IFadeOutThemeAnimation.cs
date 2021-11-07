// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Media.Animation.IFadeOutThemeAnimation
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Media.Animation
{
  [Guid(2301062057, 65492, 17846, 155, 154, 206, 212, 137, 81, 231, 18)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (FadeOutThemeAnimation))]
  [WebHostHidden]
  internal interface IFadeOutThemeAnimation
  {
    string TargetName { get; set; }
  }
}
