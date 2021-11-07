// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Automation.Provider.IDropTargetProvider
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Automation.Provider
{
  /// <summary>Enables a Microsoft UI Automation element to describe itself as an element that can receive a drop of a dragged element as part of a drag-and-drop operation. Implement this interface in order to support the capabilities that an automation client requests with a GetPattern call and PatternInterface.DropTarget.</summary>
  [Guid(2049203165, 46168, 20448, 152, 200, 170, 200, 157, 245, 109, 97)]
  [WebHostHidden]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public interface IDropTargetProvider
  {
    /// <summary>Gets a string that indicates what will happen when the item is dropped.</summary>
    /// <returns>A string that indicates what will happen when the item is dropped.</returns>
    string DropEffect { get; }

    /// <summary>Gets an array of strings that enumerates possible drop effects when this item is dropped.</summary>
    /// <returns>An array of strings that enumerates possible drop effects when this item is dropped.</returns>
    string[] DropEffects { get; }
  }
}
