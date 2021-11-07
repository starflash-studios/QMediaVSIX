// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Automation.Provider.IMultipleViewProvider
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Automation.Provider
{
  /// <summary>Exposes methods and properties to support Microsoft UI Automation client access to controls that provide, and are able to switch between, multiple representations of the same set of information or child controls. Implement this interface in order to support the capabilities that an automation client requests with a GetPattern call and PatternInterface.MultipleView.</summary>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [WebHostHidden]
  [Guid(3491029398, 3664, 18499, 165, 210, 194, 40, 151, 200, 132, 90)]
  public interface IMultipleViewProvider
  {
    /// <summary>Gets the current control-specific view.</summary>
    /// <returns>The view identifier for the current view of the UI Automation element.</returns>
    int CurrentView { get; }

    /// <summary>Retrieves a collection of control-specific view identifiers.</summary>
    /// <returns>A collection of values that identifies the views available for a UI Automation element.</returns>
    int[] GetSupportedViews();

    /// <summary>Retrieves the name of a control-specific view.</summary>
    /// <param name="viewId">The view identifier.</param>
    /// <returns>A localized name for the view.</returns>
    string GetViewName(int viewId);

    /// <summary>Sets the current control-specific view.</summary>
    /// <param name="viewId">A view identifier.</param>
    void SetCurrentView(int viewId);
  }
}
