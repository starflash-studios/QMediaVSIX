// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Media.Animation.ISplitCloseThemeAnimationStatics
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Media.Animation
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (SplitCloseThemeAnimation))]
  [WebHostHidden]
  [Guid(2057915881, 52379, 20112, 161, 26, 0, 80, 162, 33, 106, 158)]
  internal interface ISplitCloseThemeAnimationStatics
  {
    DependencyProperty OpenedTargetNameProperty { get; }

    DependencyProperty OpenedTargetProperty { get; }

    DependencyProperty ClosedTargetNameProperty { get; }

    DependencyProperty ClosedTargetProperty { get; }

    DependencyProperty ContentTargetNameProperty { get; }

    DependencyProperty ContentTargetProperty { get; }

    DependencyProperty OpenedLengthProperty { get; }

    DependencyProperty ClosedLengthProperty { get; }

    DependencyProperty OffsetFromCenterProperty { get; }

    DependencyProperty ContentTranslationDirectionProperty { get; }

    DependencyProperty ContentTranslationOffsetProperty { get; }
  }
}
