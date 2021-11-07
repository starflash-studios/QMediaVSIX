// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Media.AcrylicBackgroundSource
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Media
{
  /// <summary>Defines values that specify whether the brush samples from the app content or from the content behind the app window.</summary>
  [WebHostHidden]
  [ContractVersion(typeof (UniversalApiContract), 327680)]
  public enum AcrylicBackgroundSource
  {
    /// <summary>The brush samples from the content behind the app window.</summary>
    HostBackdrop,
    /// <summary>The brush samples from the app content.</summary>
    Backdrop,
  }
}
