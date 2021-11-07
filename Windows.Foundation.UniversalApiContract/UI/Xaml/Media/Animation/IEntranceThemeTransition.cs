// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Media.Animation.IEntranceThemeTransition
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Media.Animation
{
  [Guid(124357641, 43235, 16794, 160, 29, 116, 16, 160, 174, 142, 200)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [WebHostHidden]
  [ExclusiveTo(typeof (EntranceThemeTransition))]
  internal interface IEntranceThemeTransition
  {
    double FromHorizontalOffset { get; set; }

    double FromVerticalOffset { get; set; }

    bool IsStaggeringEnabled { get; set; }
  }
}
