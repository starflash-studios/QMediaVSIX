// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Input.StandardUICommandKind
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Input
{
  /// <summary>Specifies the set of platform commands (with pre-defined properties such as icon, keyboard accelerator, and description) that can be used with a StandardUICommand.</summary>
  [WebHostHidden]
  [ContractVersion(typeof (UniversalApiContract), 458752)]
  public enum StandardUICommandKind
  {
    /// <summary>No command.  Default.</summary>
    None,
    /// <summary>Specifies the cut command.</summary>
    Cut,
    /// <summary>Specifies the copy command.</summary>
    Copy,
    /// <summary>Specifies the paste command.</summary>
    Paste,
    /// <summary>Specifies the select all command.</summary>
    SelectAll,
    /// <summary>Specifies the delete command.</summary>
    Delete,
    /// <summary>Specifies the share command.</summary>
    Share,
    /// <summary>Specifies the save command.</summary>
    Save,
    /// <summary>Specifies the open command.</summary>
    Open,
    /// <summary>Specifies the close command.</summary>
    Close,
    /// <summary>Specifies the pause command.</summary>
    Pause,
    /// <summary>Specifies the play command.</summary>
    Play,
    /// <summary>Specifies the stop command.</summary>
    Stop,
    /// <summary>Specifies the forward command.</summary>
    Forward,
    /// <summary>Specifies the backward command.</summary>
    Backward,
    /// <summary>Specifies the undo command.</summary>
    Undo,
    /// <summary>Specifies the redo command.</summary>
    Redo,
  }
}
