// Decompiled with JetBrains decompiler
// Type: Windows.UI.Input.Preview.Injection.InjectedInputKeyOptions
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Input.Preview.Injection
{
  /// <summary>Specifies the various options, or modifiers, used to simulate input from physical or virtual keyboards through InjectedInputKeyboardInfo.</summary>
  [Flags]
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  public enum InjectedInputKeyOptions : uint
  {
    /// <summary>No keystroke modifier. Default.</summary>
    None = 0,
    /// <summary>The key is an extended key, such as a function key or a key on the numeric keypad.</summary>
    ExtendedKey = 1,
    /// <summary>The key is released.</summary>
    KeyUp = 2,
    /// <summary>The OEM, device-dependent identifier for the key on the keyboard.A keyboard generates two scan codes when the user types a key—one when the user presses the key and another when the user releases the key.</summary>
    ScanCode = 8,
    /// <summary>The key is a Unicode value.</summary>
    Unicode = 4,
  }
}
