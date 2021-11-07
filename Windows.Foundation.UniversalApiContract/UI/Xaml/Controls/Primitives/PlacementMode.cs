// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.Primitives.PlacementMode
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Controls.Primitives
{
  /// <summary>Defines constants that specify the preferred location for positioning a ToolTip relative to a visual element.</summary>
  [WebHostHidden]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public enum PlacementMode
  {
    /// <summary>The preferred location of the ToolTip is below the target element when element receives keyboard focus, at the bottom of the mouse pointer when element is hovered over with pointer.</summary>
    Bottom = 2,
    /// <summary>The preferred location of the ToolTip is to the right of the target element when element receives keyboard focus, to the right of the mouse pointer when element is hovered over with pointer.</summary>
    Right = 4,
    /// <summary>The preferred location of the ToolTip is with the top-left corner of the tooltip positioned at the mouse pointer location when hovered over with mouse, above the target element when focused with keyboard.</summary>
    Mouse = 7,
    /// <summary>The preferred location of the ToolTip is to the left of the target element when element receives keyboard focus, to the left of the mouse pointer when element is hovered over with pointer.</summary>
    Left = 9,
    /// <summary>The preferred location of the ToolTip is above the target element when element receives keyboard focus, at the top of the mouse pointer when element is hovered over with pointer.</summary>
    Top = 10, // 0x0000000A
  }
}
