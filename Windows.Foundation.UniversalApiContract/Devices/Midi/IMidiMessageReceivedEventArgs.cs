// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Midi.IMidiMessageReceivedEventArgs
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.Midi
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (MidiMessageReceivedEventArgs))]
  [Guid(1985375830, 62248, 19281, 144, 125, 179, 168, 206, 150, 191, 128)]
  internal interface IMidiMessageReceivedEventArgs
  {
    IMidiMessage Message { get; }
  }
}
