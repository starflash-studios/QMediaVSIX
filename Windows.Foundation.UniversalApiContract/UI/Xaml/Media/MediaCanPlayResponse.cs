// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Media.MediaCanPlayResponse
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Media
{
  /// <summary>Describes the likelihood that the media engine can play a media source based on its file type and characteristics.</summary>
  [WebHostHidden]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public enum MediaCanPlayResponse
  {
    /// <summary>Media engine cannot support the media source.</summary>
    NotSupported,
    /// <summary>Media engine might support the media source.</summary>
    Maybe,
    /// <summary>Media engine can probably support the media source.</summary>
    Probably,
  }
}
