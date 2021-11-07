// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Media.FastPlayFallbackBehaviour
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Media
{
  /// <summary>Defines constants that specify how MediaTransportControls fast-forward/backward buttons behave.</summary>
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  [WebHostHidden]
  public enum FastPlayFallbackBehaviour
  {
    /// <summary>If the media doesn't support fast-forward/fast-rewind, the media skips 30 seconds.</summary>
    Skip,
    /// <summary>If the media doesn't support fast-forward/fast-rewind, the buttons are hidden.</summary>
    Hide,
    /// <summary>If the media doesn't support fast-forward/fast-rewind, the buttons are disabled.</summary>
    Disable,
  }
}
