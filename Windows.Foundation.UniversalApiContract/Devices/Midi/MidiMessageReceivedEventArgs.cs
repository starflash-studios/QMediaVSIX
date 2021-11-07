// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Midi.MidiMessageReceivedEventArgs
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.Midi
{
  /// <summary>Provides data for the MessageReceived event.</summary>
  [Threading(ThreadingModel.Both)]
  [DualApiPartition(version = 167772160)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [MarshalingBehavior(MarshalingType.Agile)]
  public sealed class MidiMessageReceivedEventArgs : IMidiMessageReceivedEventArgs
  {
    /// <summary>The MIDI message.</summary>
    /// <returns>The MIDI message.</returns>
    public extern IMidiMessage Message { [MethodImpl] get; }
  }
}
