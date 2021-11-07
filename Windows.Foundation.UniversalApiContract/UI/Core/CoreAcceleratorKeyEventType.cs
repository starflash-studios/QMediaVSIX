// Decompiled with JetBrains decompiler
// Type: Windows.UI.Core.CoreAcceleratorKeyEventType
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Core
{
  /// <summary>Specifies the set of possible accelerator key events that can invoke a callback.</summary>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [WebHostHidden]
  public enum CoreAcceleratorKeyEventType
  {
    /// <summary>A key is pressed down.</summary>
    KeyDown,
    /// <summary>A key is raised.</summary>
    KeyUp,
    /// <summary>A character key is pressed.</summary>
    Character,
    /// <summary>A dead character key is pressed. (A *dead character* key is a key that modifies the next keypress, like an accent character.)</summary>
    DeadCharacter,
    /// <summary>A system key is pressed down.</summary>
    SystemKeyDown,
    /// <summary>A system key is raised.</summary>
    SystemKeyUp,
    /// <summary>A system character key is pressed.</summary>
    SystemCharacter,
    /// <summary>A system dead character key is pressed.</summary>
    SystemDeadCharacter,
    /// <summary>A Unicode character key is pressed.</summary>
    UnicodeCharacter,
  }
}
