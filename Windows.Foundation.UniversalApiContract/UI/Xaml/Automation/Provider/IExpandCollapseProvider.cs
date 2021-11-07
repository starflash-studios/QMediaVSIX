// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Automation.Provider.IExpandCollapseProvider
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Automation.Provider
{
  /// <summary>Exposes methods and properties to support access by a Microsoft UI Automation client to controls that visually expand to display content and that collapse to hide content. Implement this interface in order to support the capabilities that an automation client requests with a GetPattern call and PatternInterface.ExpandCollapse.</summary>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [WebHostHidden]
  [Guid(1236042649, 54822, 17731, 148, 185, 166, 217, 169, 89, 58, 246)]
  public interface IExpandCollapseProvider
  {
    /// <summary>Gets the state (expanded or collapsed) of the control.</summary>
    /// <returns>The state (expanded or collapsed) of the control.</returns>
    ExpandCollapseState ExpandCollapseState { get; }

    /// <summary>Hides all nodes, controls, or content that are descendants of the control.</summary>
    void Collapse();

    /// <summary>Displays all child nodes, controls, or content of the control.</summary>
    void Expand();
  }
}
