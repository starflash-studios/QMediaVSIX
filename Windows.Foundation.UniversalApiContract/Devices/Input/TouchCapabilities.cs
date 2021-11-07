// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Input.TouchCapabilities
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.Input
{
  /// <summary>Supports the ability to determine the touch capabilities of any connected touch digitizers.</summary>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Activatable(65536, "Windows.Foundation.UniversalApiContract")]
  [MarshalingBehavior(MarshalingType.Agile)]
  public sealed class TouchCapabilities : ITouchCapabilities
  {
    /// <summary>Initializes a new instance of the TouchCapabilities class.</summary>
    [MethodImpl]
    public extern TouchCapabilities();

    /// <summary>Gets a value that indicates whether a touch digitizer is detected.</summary>
    /// <returns>The number of touch digitizers detected. Typically 0 or 1.</returns>
    public extern int TouchPresent { [MethodImpl] get; }

    /// <summary>Gets the minimum number of contacts supported by all the digitizers.</summary>
    /// <returns>Gets the minimum number of contacts supported by all the digitizers.</returns>
    public extern uint Contacts { [MethodImpl] get; }
  }
}
