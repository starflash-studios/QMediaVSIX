// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Automation.Provider.IDockProvider
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Automation.Provider
{
  /// <summary>Exposes methods and properties to support access by a Microsoft UI Automation client to controls that expose their dock properties in a docking container. Implement this interface in order to support the capabilities that an automation client requests with a GetPattern call and PatternInterface.Dock.</summary>
  [WebHostHidden]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(1220690936, 30897, 17568, 172, 95, 117, 7, 87, 188, 222, 60)]
  public interface IDockProvider
  {
    /// <summary>Gets the current DockPosition of the control in a docking container.</summary>
    /// <returns>The DockPosition of the control, relative to the boundaries of the docking container and to other elements in the container.</returns>
    DockPosition DockPosition { get; }

    /// <summary>Docks the control in a docking container.</summary>
    /// <param name="dockPosition">The dock position, relative to the boundaries of the docking container and to other elements in the container.</param>
    void SetDockPosition(DockPosition dockPosition);
  }
}
