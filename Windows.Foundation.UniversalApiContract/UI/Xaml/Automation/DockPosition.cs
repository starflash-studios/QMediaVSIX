// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Automation.DockPosition
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Automation
{
  /// <summary>Contains values that specify the dock position of an object within a docking container. Used by IDockProvider.DockPosition.</summary>
  [WebHostHidden]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public enum DockPosition
  {
    /// <summary>Indicates that the UI Automation element is docked along the top edge of the docking container.</summary>
    Top,
    /// <summary>Indicates that the UI Automation element is docked along the left edge of the docking container.</summary>
    Left,
    /// <summary>Indicates that the UI Automation element is docked along the bottom edge of the docking container.</summary>
    Bottom,
    /// <summary>Indicates that the UI Automation element is docked along the right edge of the docking container.</summary>
    Right,
    /// <summary>Indicates that the UI Automation element is docked along all edges of the docking container and fills all available space within the container.</summary>
    Fill,
    /// <summary>Indicates that the UI Automation element is not docked to any edge of the docking container.</summary>
    None,
  }
}
