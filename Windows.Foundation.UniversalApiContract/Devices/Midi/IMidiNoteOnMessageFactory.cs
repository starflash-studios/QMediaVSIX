﻿// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Midi.IMidiNoteOnMessageFactory
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.Midi
{
  [ExclusiveTo(typeof (MidiNoteOnMessage))]
  [Guid(2604826784, 22977, 16910, 181, 23, 21, 161, 10, 169, 96, 107)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IMidiNoteOnMessageFactory
  {
    MidiNoteOnMessage CreateMidiNoteOnMessage(
      byte channel,
      byte note,
      byte velocity);
  }
}