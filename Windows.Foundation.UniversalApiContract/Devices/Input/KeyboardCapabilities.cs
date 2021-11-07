// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Input.KeyboardCapabilities
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.Input
{
  /// <summary>Supports the ability to determine the capabilities of any connected hardware keyboards.</summary>
  [Activatable(65536, "Windows.Foundation.UniversalApiContract")]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [MarshalingBehavior(MarshalingType.Agile)]
  public sealed class KeyboardCapabilities : IKeyboardCapabilities
  {
    /// <summary>Initializes a new instance of the KeyboardCapabilities class.</summary>
    [MethodImpl]
    public extern KeyboardCapabilities();

    /// <summary>Gets a value that indicates whether a device identifying itself as a keyboard is detected.</summary>
    /// <returns>Returns 1 if a device identifying itself as a keyboard is detected. Otherwise, returns 0.</returns>
    public extern int KeyboardPresent { [MethodImpl] get; }
  }
}
