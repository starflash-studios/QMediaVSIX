// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Navigation.INavigatingCancelEventArgs2
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml.Media.Animation;

namespace Windows.UI.Xaml.Navigation
{
  [Guid(1409791748, 33095, 17219, 131, 143, 221, 30, 233, 8, 193, 55)]
  [WebHostHidden]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (NavigatingCancelEventArgs))]
  internal interface INavigatingCancelEventArgs2
  {
    object Parameter { get; }

    NavigationTransitionInfo NavigationTransitionInfo { get; }
  }
}
