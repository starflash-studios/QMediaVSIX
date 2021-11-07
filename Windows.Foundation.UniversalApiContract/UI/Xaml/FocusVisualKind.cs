// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.FocusVisualKind
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml
{
  /// <summary>Specifies the visual feedback used to indicate the UI element with focus when navigating with a keyboard or gamepad.</summary>
  [WebHostHidden]
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  public enum FocusVisualKind
  {
    /// <summary>A dotted line rectangle. Also known as "marching ants". </summary>
    DottedLine,
    /// <summary>A solid line rectangle composed of an inner and outer rectangle of contrasting colors.</summary>
    HighVisibility,
    /// <summary>A solid line rectangle, surrounded by a glowing light effect to simulate depth. </summary>
    [ContractVersion("Windows.Foundation.UniversalApiContract", 393216)] Reveal,
  }
}
