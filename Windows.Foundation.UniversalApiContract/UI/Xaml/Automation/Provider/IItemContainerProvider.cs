// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Automation.Provider.IItemContainerProvider
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Automation.Provider
{
  /// <summary>Exposes a Microsoft UI Automation method to enable applications to find an element in a container, such as a virtualized list. Implement this interface in order to support the capabilities that an automation client requests with a GetPattern call and PatternInterface.ItemContainer.</summary>
  [WebHostHidden]
  [Guid(4015839301, 57812, 16628, 186, 213, 199, 250, 212, 74, 112, 62)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public interface IItemContainerProvider
  {
    /// <summary>Retrieves an element by the specified property value.</summary>
    /// <param name="startAfter">The item in the container after which to begin the search.</param>
    /// <param name="automationProperty">The property that contains the value to retrieve.</param>
    /// <param name="value">The value to retrieve.</param>
    /// <returns>The first item that matches the search criterion; otherwise, null.</returns>
    IRawElementProviderSimple FindItemByProperty(
      IRawElementProviderSimple startAfter,
      AutomationProperty automationProperty,
      object value);
  }
}
