// Decompiled with JetBrains decompiler
// Type: Windows.UI.Input.RadialControllerMenuKnownIcon
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Input
{
  /// <summary>Specifies the set of system icons available for a custom RadialController tool on the RadialControllerMenu.</summary>
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  public enum RadialControllerMenuKnownIcon
  {
    /// <summary>Icon for the Scroll command.</summary>
    Scroll,
    /// <summary>Icon for the Zoom command.</summary>
    Zoom,
    /// <summary>Icon for the Undo/Redo commands.</summary>
    UndoRedo,
    /// <summary>Icon for the Volume command.</summary>
    Volume,
    /// <summary>Icon for the Next/Previous track media commands.</summary>
    NextPreviousTrack,
    /// <summary>Icon for the InkToolbar  RulerButton.</summary>
    Ruler,
    /// <summary>Icon for the InkToolbar color palette.</summary>
    InkColor,
    /// <summary>Icon for the InkToolbar stroke size setting.</summary>
    InkThickness,
    /// <summary>Icon for the InkToolbar  PenButton.</summary>
    PenType,
  }
}
