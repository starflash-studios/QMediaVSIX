// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Media.Animation.ISplitCloseThemeAnimation
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml.Controls.Primitives;

namespace Windows.UI.Xaml.Media.Animation
{
  [ExclusiveTo(typeof (SplitCloseThemeAnimation))]
  [Guid(1333368088, 65337, 20112, 187, 116, 42, 189, 86, 2, 116, 2)]
  [WebHostHidden]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface ISplitCloseThemeAnimation
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
