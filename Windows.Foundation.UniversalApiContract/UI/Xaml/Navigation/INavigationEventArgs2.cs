// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Navigation.INavigationEventArgs2
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml.Media.Animation;

namespace Windows.UI.Xaml.Navigation
{
  [WebHostHidden]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (NavigationEventArgs))]
  [Guid(3690951129, 38810, 19246, 164, 155, 59, 177, 127, 222, 245, 116)]
  internal interface INavigationEventArgs2
  {
    NavigationTransitionInfo NavigationTransitionInfo { get; }
  }
}
