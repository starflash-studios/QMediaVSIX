// Decompiled with JetBrains decompiler
// Type: Windows.UI.Core.CharacterReceivedEventArgs
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Core
{
  /// <summary>Provides the arguments returned by the event raised when a character is received by the input queue.</summary>
  [MarshalingBehavior(MarshalingType.Standard)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [WebHostHidden]
  public sealed class CharacterReceivedEventArgs : ICharacterReceivedEventArgs, ICoreWindowEventArgs
  {
    /// <summary>Gets the key code of the character received by the input queue.</summary>
    /// <returns>The character in UTF-32 encoding.</returns>
    public extern uint KeyCode { [MethodImpl] get; }

    /// <summary>Gets the status of the physical key press that raised the character-received event.</summary>
    /// <returns>The status of the key that was pressed.</returns>
    public extern CorePhysicalKeyStatus KeyStatus { [MethodImpl] get; }

    /// <summary>Gets or sets whether the character-received event was handled or not.</summary>
    /// <returns>True if the character received event has been handled; false if it has not.</returns>
    public extern bool Handled { [MethodImpl] get; [MethodImpl] set; }
  }
}
