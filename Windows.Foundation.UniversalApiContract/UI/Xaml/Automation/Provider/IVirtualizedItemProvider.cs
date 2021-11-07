// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Automation.Provider.IVirtualizedItemProvider
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Automation.Provider
{
  /// <summary>Exposes a method to support the virtualized item control pattern. Implement this interface in order to support the capabilities that an automation client requests with a GetPattern call and PatternInterface.VirtualizedItem.</summary>
  [Guid(399810635, 54872, 18656, 165, 116, 90, 81, 108, 88, 223, 167)]
  [WebHostHidden]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public interface IVirtualizedItemProvider
  {
    /// <summary>Makes the virtual item fully accessible as a UI Automation element.</summary>
    void Realize();
  }
}
