// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Automation.Peers.AutomationNavigationDirection
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Automation.Peers
{
  /// <summary>Defines the directions of navigation within the Microsoft UI Automation tree.</summary>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [WebHostHidden]
  public enum AutomationNavigationDirection
  {
    /// <summary>Navigate to the parent of the current node.</summary>
    Parent,
    /// <summary>Navigate to the next sibling of the current node.</summary>
    NextSibling,
    /// <summary>Navigate to the previous sibling of the current node.</summary>
    PreviousSibling,
    /// <summary>Navigate to the first child of the current node.</summary>
    FirstChild,
    /// <summary>Navigate to the last child of the current node.</summary>
    LastChild,
  }
}
