// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Media.Animation.ISplitOpenThemeAnimation
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml.Controls.Primitives;

namespace Windows.UI.Xaml.Media.Animation
{
  [ExclusiveTo(typeof (SplitOpenThemeAnimation))]
  [Guid(2019547050, 21590, 17977, 143, 210, 38, 186, 230, 165, 255, 228)]
  [WebHostHidden]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface ISplitOpenThemeAnimation
  {
    string OpenedTargetName { get; set; }

    DependencyObject OpenedTarget { get; set; }

    string ClosedTargetName { get; set; }

    DependencyObject ClosedTarget { get; set; }

    string ContentTargetName { get; set; }

    DependencyObject ContentTarget { get; set; }

    double OpenedLength { get; set; }

    double ClosedLength { get; set; }

    double OffsetFromCenter { get; set; }

    AnimationDirection ContentTranslationDirection { get; set; }

    double ContentTranslationOffset { get; set; }
  }
}
