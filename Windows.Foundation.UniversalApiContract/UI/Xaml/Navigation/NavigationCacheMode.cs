// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Navigation.NavigationCacheMode
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Navigation
{
  /// <summary>Specifies caching characteristics for a page involved in a navigation.</summary>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [WebHostHidden]
  public enum NavigationCacheMode
  {
    /// <summary>The page is never cached and a new instance of the page is created on each visit.</summary>
    Disabled,
    /// <summary>The page is cached and the cached instance is reused for every visit regardless of the cache size for the frame.</summary>
    Required,
    /// <summary>The page is cached, but the cached instance is discarded when the size of the cache for the frame is exceeded.</summary>
    Enabled,
  }
}
