// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.InkToolbarTool
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Controls
{
  /// <summary>Defines constants that specify the type of built-in or custom tool associated with the InkToolbarToolButton.</summary>
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  [WebHostHidden]
  public enum InkToolbarTool
  {
    /// <summary>A pen tool that renders a solid, opaque stroke, with the stroke size dependent on the pen pressure detected (default size is 2x2 pixels).</summary>
    BallpointPen,
    /// <summary>A pen tool that renders a soft-edged, semi-transparent stroke that can be layered for shading effects. The stroke opacity is dependent on the pen pressure detected.</summary>
    Pencil,
    /// <summary>A pen tool that renders a semi-transparent highlighter overlay stroke.</summary>
    Highlighter,
    /// <summary>A pen tool that deletes any ink strokes that intersect with the erase stroke.</summary>
    Eraser,
    /// <summary>A custom pen tool.</summary>
    CustomPen,
    /// <summary>A custom non-pen tool.</summary>
    CustomTool,
  }
}
