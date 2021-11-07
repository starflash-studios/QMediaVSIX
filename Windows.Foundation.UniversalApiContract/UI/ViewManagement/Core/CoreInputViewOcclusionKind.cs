// Decompiled with JetBrains decompiler
// Type: Windows.UI.ViewManagement.Core.CoreInputViewOcclusionKind
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.ViewManagement.Core
{
  /// <summary>Specifies the types of input panes supported by the CoreInputViewOcclusion object.</summary>
  [ContractVersion(typeof (UniversalApiContract), 327680)]
  public enum CoreInputViewOcclusionKind
  {
    /// <summary>Docked panes such as a Soft Input Panel (SIP) like the **Touch keyboard and handwriting panel**.</summary>
    Docked,
    /// <summary>Undocked panes such as a toolbar, or a Soft Input Panel (SIP) like the **Touch keyboard and handwriting panel**.</summary>
    Floating,
    /// <summary>Floating panes such as an inline Ink or Input Method Editor (IME) candidate window.</summary>
    Overlay,
  }
}
