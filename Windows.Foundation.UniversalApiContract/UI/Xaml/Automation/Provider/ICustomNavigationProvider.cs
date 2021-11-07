// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Automation.Provider.ICustomNavigationProvider
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml.Automation.Peers;

namespace Windows.UI.Xaml.Automation.Provider
{
  /// <summary>Exposes a method to support access by a Microsoft UI Automation client to controls that support a custom navigation order. Implement ICustomNavigationProvider to support the capabilities that an automation client requests with a GetPattern call and PatternInterface.CustomNavigation.</summary>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [WebHostHidden]
  [Guid(735618768, 12195, 18199, 178, 140, 73, 23, 206, 84, 146, 141)]
  public interface ICustomNavigationProvider
  {
    /// <summary>Gets the next element in the specified direction within the logical UI tree.</summary>
    /// <param name="direction">The specified direction.</param>
    /// <returns>The next element.</returns>
    object NavigateCustom(AutomationNavigationDirection direction);
  }
}
