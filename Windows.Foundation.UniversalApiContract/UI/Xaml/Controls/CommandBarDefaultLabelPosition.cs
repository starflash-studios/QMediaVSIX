// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.CommandBarDefaultLabelPosition
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Controls
{
  /// <summary>Defines constants that specify the placement and visibility of AppBarButton labels in a CommandBar.</summary>
  [WebHostHidden]
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  public enum CommandBarDefaultLabelPosition
  {
    /// <summary>App bar button labels are shown below the icon. Labels are visible only when the command bar is open.</summary>
    Bottom,
    /// <summary>App bar button labels are shown to the right of the icon. Labels are visible even when the command bar is closed.</summary>
    Right,
    /// <summary>App bar button labels are always hidden whether the command bar is open or closed.</summary>
    Collapsed,
  }
}
