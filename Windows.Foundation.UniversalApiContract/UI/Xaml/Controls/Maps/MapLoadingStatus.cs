// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.Maps.MapLoadingStatus
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Controls.Maps
{
  /// <summary>Specifies the LoadingStatus of the MapControl.</summary>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [WebHostHidden]
  public enum MapLoadingStatus
  {
    /// <summary>The map is loading.</summary>
    Loading,
    /// <summary>The map is loaded.</summary>
    Loaded,
    /// <summary>Map data is unavailable.</summary>
    [ContractVersion("Windows.Foundation.UniversalApiContract", 131072)] DataUnavailable,
    /// <summary>Downloaded maps manager is unavailable</summary>
    [ContractVersion("Windows.Foundation.UniversalApiContract", 524288)] DownloadedMapsManagerUnavailable,
  }
}
