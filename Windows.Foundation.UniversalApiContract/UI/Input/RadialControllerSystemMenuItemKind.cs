// Decompiled with JetBrains decompiler
// Type: Windows.UI.Input.RadialControllerSystemMenuItemKind
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Input
{
  /// <summary>Specifies the set of built-in RadialController tools available on the RadialControllerMenu.</summary>
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  public enum RadialControllerSystemMenuItemKind
  {
    /// <summary>Scroll command.</summary>
    Scroll,
    /// <summary>Zoom command.</summary>
    Zoom,
    /// <summary>Undo and Redo commands.</summary>
    UndoRedo,
    /// <summary>System volume command.</summary>
    Volume,
    /// <summary>Next and Previous track selection media commands.</summary>
    NextPreviousTrack,
  }
}
