// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.CandidateWindowAlignment
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Controls
{
  /// <summary>Defines constants that specify how the Input Method Editor (IME) window for text predictions is aligned with a text edit control.</summary>
  [WebHostHidden]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public enum CandidateWindowAlignment
  {
    /// <summary>When the hardware keyboard is used, the Input Method Editor (IME) follows the cursor. When the Soft Input Panel (SIP) is used, the Input Method Editor (IME) is docked to the Soft Input Panel (SIP).</summary>
    Default,
    /// <summary>When the hardware keyboard is used, the Input Method Editor (IME) aligns to the bottom edge and left side of the text edit control. When the Soft Input Panel (SIP) is used, the Input Method Editor (IME) is docked to the Soft Input Panel (SIP).</summary>
    BottomEdge,
  }
}
