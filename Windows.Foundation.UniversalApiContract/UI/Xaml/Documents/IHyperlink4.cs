// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Documents.IHyperlink4
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml.Input;

namespace Windows.UI.Xaml.Documents
{
  [Guid(4157614425, 33531, 16394, 164, 7, 90, 78, 230, 119, 152, 138)]
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  [ExclusiveTo(typeof (Hyperlink))]
  [WebHostHidden]
  internal interface IHyperlink4
  {
    FocusState FocusState { get; }

    XYFocusNavigationStrategy XYFocusUpNavigationStrategy { get; set; }

    XYFocusNavigationStrategy XYFocusDownNavigationStrategy { get; set; }

    XYFocusNavigationStrategy XYFocusLeftNavigationStrategy { get; set; }

    XYFocusNavigationStrategy XYFocusRightNavigationStrategy { get; set; }

    event RoutedEventHandler GotFocus;

    event RoutedEventHandler LostFocus;

    bool Focus(FocusState value);
  }
}
