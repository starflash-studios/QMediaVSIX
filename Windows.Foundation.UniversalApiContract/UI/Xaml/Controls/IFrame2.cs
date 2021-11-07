// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.IFrame2
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml.Interop;
using Windows.UI.Xaml.Media.Animation;
using Windows.UI.Xaml.Navigation;

namespace Windows.UI.Xaml.Controls
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(1060536199, 40794, 19204, 184, 24, 181, 84, 192, 105, 89, 122)]
  [ExclusiveTo(typeof (Frame))]
  [WebHostHidden]
  internal interface IFrame2
  {
    IVector<PageStackEntry> BackStack { get; }

    IVector<PageStackEntry> ForwardStack { get; }

    bool Navigate(TypeName sourcePageType, object parameter, NavigationTransitionInfo infoOverride);
  }
}
