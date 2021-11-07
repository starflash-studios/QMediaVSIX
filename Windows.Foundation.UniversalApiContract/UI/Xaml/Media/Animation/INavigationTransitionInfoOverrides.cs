// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Media.Animation.INavigationTransitionInfoOverrides
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Media.Animation
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (NavigationTransitionInfo))]
  [Guid(3645996650, 43472, 19447, 157, 176, 70, 51, 166, 157, 175, 242)]
  [WebHostHidden]
  internal interface INavigationTransitionInfoOverrides
  {
    string GetNavigationStateCore();

    void SetNavigationStateCore(string navigationState);
  }
}
