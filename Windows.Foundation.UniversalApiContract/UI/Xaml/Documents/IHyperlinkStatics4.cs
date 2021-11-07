// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Documents.IHyperlinkStatics4
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Documents
{
  [Guid(74888056, 36778, 20004, 179, 182, 233, 222, 77, 60, 112, 140)]
  [WebHostHidden]
  [ExclusiveTo(typeof (Hyperlink))]
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  internal interface IHyperlinkStatics4
  {
    DependencyProperty FocusStateProperty { get; }

    DependencyProperty XYFocusUpNavigationStrategyProperty { get; }

    DependencyProperty XYFocusDownNavigationStrategyProperty { get; }

    DependencyProperty XYFocusLeftNavigationStrategyProperty { get; }

    DependencyProperty XYFocusRightNavigationStrategyProperty { get; }
  }
}
