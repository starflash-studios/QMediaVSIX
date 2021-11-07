// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Media.Animation.IDrillInThemeAnimationStatics
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Media.Animation
{
  [ExclusiveTo(typeof (DrillInThemeAnimation))]
  [WebHostHidden]
  [Guid(3323978888, 41338, 19217, 181, 59, 164, 241, 160, 125, 75, 169)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IDrillInThemeAnimationStatics
  {
    DependencyProperty EntranceTargetNameProperty { get; }

    DependencyProperty EntranceTargetProperty { get; }

    DependencyProperty ExitTargetNameProperty { get; }

    DependencyProperty ExitTargetProperty { get; }
  }
}
