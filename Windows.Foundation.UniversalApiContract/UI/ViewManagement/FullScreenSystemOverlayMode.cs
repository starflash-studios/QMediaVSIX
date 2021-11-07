// Decompiled with JetBrains decompiler
// Type: Windows.UI.ViewManagement.FullScreenSystemOverlayMode
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.ViewManagement
{
  /// <summary>Defines constants that specify how the app responds to edge gestures when in full-screen mode.</summary>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public enum FullScreenSystemOverlayMode
  {
    /// <summary>Edge gestures call up system overlays, like the taskbar and title bar.</summary>
    Standard,
    /// <summary>Edge gestures call up a temporary UI, which in turn can be used to call up system overlays corresponding to that edge.</summary>
    Minimal,
  }
}
