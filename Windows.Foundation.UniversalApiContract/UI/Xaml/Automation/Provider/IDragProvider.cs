// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Automation.Provider.IDragProvider
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Automation.Provider
{
  /// <summary>Enables a Microsoft UI Automation element to describe itself as an element that can be dragged as part of a drag-and-drop operation. Implement this interface in order to support the capabilities that an automation client requests with a GetPattern call and PatternInterface.Drag.</summary>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(779585193, 32764, 20311, 185, 101, 30, 241, 243, 115, 245, 70)]
  [WebHostHidden]
  public interface IDragProvider
  {
    /// <summary>Gets a value indicating whether an item is currently being dragged.</summary>
    /// <returns>**true** if the item is being dragged. Otherwise, **false**.</returns>
    bool IsGrabbed { get; }

    /// <summary>Gets a string that indicates what will happen when the item is dropped.</summary>
    /// <returns>A string that indicates what will happen when the item is dropped.</returns>
    string DropEffect { get; }

    /// <summary>Gets an array of strings that enumerates possible drop effects when this item is dropped.</summary>
    /// <returns>An array of strings that enumerates possible drop effects when this item is dropped.</returns>
    string[] DropEffects { get; }

    /// <summary>Gets an array of UI Automation elements that are being dragged as part of this drag operation.</summary>
    /// <returns>An array of UI Automation elements that are being dragged. Null if this item is an individual item being dragged. Used to enable providers that support dragging multiple items at a time to create an intermediary IDragProvider that encapsulates all of the items being dragged.</returns>
    IRawElementProviderSimple[] GetGrabbedItems();
  }
}
