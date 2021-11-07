// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Media.Animation.IDrillOutThemeAnimationStatics
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Media.Animation
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(3199589275, 9751, 18568, 128, 221, 114, 250, 123, 182, 250, 195)]
  [ExclusiveTo(typeof (DrillOutThemeAnimation))]
  [WebHostHidden]
  internal interface IDrillOutThemeAnimationStatics
  {
    DependencyProperty EntranceTargetNameProperty { get; }

    DependencyProperty EntranceTargetProperty { get; }

    DependencyProperty ExitTargetNameProperty { get; }

    DependencyProperty ExitTargetProperty { get; }
  }
}
