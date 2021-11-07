// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Media.LoadedImageSourceLoadStatus
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Media
{
  /// <summary>Defines constants that specify whether an image loaded, or why it failed to load.</summary>
  [WebHostHidden]
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  public enum LoadedImageSourceLoadStatus
  {
    /// <summary>The image loaded.</summary>
    Success,
    /// <summary>The image did not load due to a network error.</summary>
    NetworkError,
    /// <summary>The image did not load because the image format is invalid.</summary>
    InvalidFormat,
    /// <summary>The image did not load for some other reason.</summary>
    Other,
  }
}
