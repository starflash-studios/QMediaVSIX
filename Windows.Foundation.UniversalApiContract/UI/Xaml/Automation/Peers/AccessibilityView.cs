// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Automation.Peers.AccessibilityView
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Automation.Peers
{
  /// <summary>Declares how a control should included in different views of a Microsoft UI Automation tree.</summary>
  [WebHostHidden]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public enum AccessibilityView
  {
    /// <summary>The control is included in the **Raw** view of a Microsoft UI Automation tree.</summary>
    Raw,
    /// <summary>The control is included in the **Control** view of a Microsoft UI Automation tree.</summary>
    Control,
    /// <summary>The control is included in the **Content** view of a Microsoft UI Automation tree. This is the default.</summary>
    Content,
  }
}
