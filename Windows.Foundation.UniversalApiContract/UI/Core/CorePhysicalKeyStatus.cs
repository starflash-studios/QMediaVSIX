// Decompiled with JetBrains decompiler
// Type: Windows.UI.Core.CorePhysicalKeyStatus
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Core
{
  /// <summary>Specifies the set of physical key status items that can be obtained.</summary>
  [WebHostHidden]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public struct CorePhysicalKeyStatus
  {
    /// <summary>The number of times a key was pressed.</summary>
    public uint RepeatCount;
    /// <summary>The scan code for a key that was pressed.</summary>
    public uint ScanCode;
    /// <summary>Whether the key that was pressed maps to an extended ASCII character.</summary>
    public bool IsExtendedKey;
    /// <summary>Whether the menu key is currently pressed down.</summary>
    public bool IsMenuKeyDown;
    /// <summary>Whether a key is currently pressed down.</summary>
    public bool WasKeyDown;
    /// <summary>Whether a key has moved from a pressed to a released status.</summary>
    public bool IsKeyReleased;
  }
}
