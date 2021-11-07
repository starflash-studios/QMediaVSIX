// Decompiled with JetBrains decompiler
// Type: Windows.UI.Input.Preview.Injection.InjectedInputKeyboardInfo
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Input.Preview.Injection
{
  /// <summary>Represents programmatically generated keyboard input.</summary>
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  [Activatable(196608, "Windows.Foundation.UniversalApiContract")]
  public sealed class InjectedInputKeyboardInfo : IInjectedInputKeyboardInfo
  {
    /// <summary>Creates a new InjectedInputKeyboardInfo object that is used to specify the keyboard input to inject.</summary>
    [MethodImpl]
    public extern InjectedInputKeyboardInfo();

    /// <summary>Gets or sets the various options, or modifiers, used to simulate input from physical or virtual keyboards.</summary>
    /// <returns>The options, or modifiers, for the keyboard input.</returns>
    public extern InjectedInputKeyOptions KeyOptions { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets an OEM, device-dependent identifier for a key on a physical keyboard.</summary>
    /// <returns>The device-dependent identifier for the key on the keyboard.</returns>
    public extern ushort ScanCode { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets a device-independent identifier mapped to a key on a physical or software keyboard.</summary>
    /// <returns>The device-independent identifier for the key on the keyboard.</returns>
    public extern ushort VirtualKey { [MethodImpl] get; [MethodImpl] set; }
  }
}
