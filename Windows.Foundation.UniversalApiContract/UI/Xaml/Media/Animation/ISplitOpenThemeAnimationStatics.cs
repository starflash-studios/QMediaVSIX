// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Media.Animation.ISplitOpenThemeAnimationStatics
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Media.Animation
{
  [WebHostHidden]
  [ExclusiveTo(typeof (SplitOpenThemeAnimation))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(2370632329, 14993, 17805, 176, 251, 76, 173, 98, 92, 191, 141)]
  internal interface ISplitOpenThemeAnimationStatics
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
