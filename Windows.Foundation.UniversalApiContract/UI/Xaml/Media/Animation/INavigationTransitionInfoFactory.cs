// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Media.Animation.INavigationTransitionInfoFactory
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Media.Animation
{
  [ExclusiveTo(typeof (NavigationTransitionInfo))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [WebHostHidden]
  [Guid(3992254677, 44899, 20395, 157, 74, 135, 146, 127, 130, 221, 107)]
  internal interface INavigationTransitionInfoFactory
  {
    NavigationTransitionInfo CreateInstance(
      object baseInterface,
      out object innerInterface);
  }
}
