// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Navigation.IPageStackEntry
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml.Interop;
using Windows.UI.Xaml.Media.Animation;

namespace Windows.UI.Xaml.Navigation
{
  [WebHostHidden]
  [ExclusiveTo(typeof (PageStackEntry))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(4018672806, 37768, 19146, 133, 114, 64, 81, 148, 6, 144, 128)]
  internal interface IPageStackEntry
  {
    TypeName SourcePageType { get; }

    object Parameter { get; }

    NavigationTransitionInfo NavigationTransitionInfo { get; }
  }
}
