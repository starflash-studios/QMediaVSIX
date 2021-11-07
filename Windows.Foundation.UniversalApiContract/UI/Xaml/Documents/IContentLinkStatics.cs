// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Documents.IContentLinkStatics
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Documents
{
  [ExclusiveTo(typeof (ContentLink))]
  [ContractVersion(typeof (UniversalApiContract), 393216)]
  [Guid(2739810403, 60182, 18510, 163, 223, 82, 43, 154, 131, 46, 110)]
  [WebHostHidden]
  internal interface IContentLinkStatics
  {
    DependencyProperty BackgroundProperty { get; }

    DependencyProperty CursorProperty { get; }

    DependencyProperty XYFocusLeftProperty { get; }

    DependencyProperty XYFocusRightProperty { get; }

    DependencyProperty XYFocusUpProperty { get; }

    DependencyProperty XYFocusDownProperty { get; }

    DependencyProperty ElementSoundModeProperty { get; }

    DependencyProperty FocusStateProperty { get; }

    DependencyProperty XYFocusUpNavigationStrategyProperty { get; }

    DependencyProperty XYFocusDownNavigationStrategyProperty { get; }

    DependencyProperty XYFocusLeftNavigationStrategyProperty { get; }

    DependencyProperty XYFocusRightNavigationStrategyProperty { get; }

    DependencyProperty IsTabStopProperty { get; }

    DependencyProperty TabIndexProperty { get; }
  }
}
