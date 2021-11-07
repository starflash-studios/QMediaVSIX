// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Automation.Provider.IToggleProvider
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Automation.Provider
{
  /// <summary>Exposes methods and properties to support Microsoft UI Automation client access to controls that can cycle through a set of states and maintain a particular state. Implement this interface in order to support the capabilities that an automation client requests with a GetPattern call and PatternInterface.Toggle.</summary>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(2478342800, 25967, 17655, 174, 175, 120, 184, 249, 68, 208, 98)]
  [WebHostHidden]
  public interface IToggleProvider
  {
    /// <summary>Gets the toggle state of the control.</summary>
    /// <returns>The toggle state of the control, as a value of the enumeration.</returns>
    ToggleState ToggleState { get; }

    /// <summary>Cycles through the toggle states of a control.</summary>
    void Toggle();
  }
}
