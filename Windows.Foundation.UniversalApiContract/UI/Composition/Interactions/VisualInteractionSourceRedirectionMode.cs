// Decompiled with JetBrains decompiler
// Type: Windows.UI.Composition.Interactions.VisualInteractionSourceRedirectionMode
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Composition.Interactions
{
  /// <summary>Indicates what input should be redirected to the InteractionTracker.</summary>
  [WebHostHidden]
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  public enum VisualInteractionSourceRedirectionMode
  {
    /// <summary>Redirection is off, all input goes to the UI thread.</summary>
    Off,
    /// <summary>Pointer input goes to the UI thread, Precision Touchpad input goes to the compositor.</summary>
    CapableTouchpadOnly,
    /// <summary>
    /// </summary>
    [ContractVersion("Windows.Foundation.UniversalApiContract", 393216)] PointerWheelOnly,
    /// <summary>
    /// </summary>
    [ContractVersion("Windows.Foundation.UniversalApiContract", 393216)] CapableTouchpadAndPointerWheel,
  }
}
