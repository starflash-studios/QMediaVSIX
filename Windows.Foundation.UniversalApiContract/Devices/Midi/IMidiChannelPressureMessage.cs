﻿// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Midi.IMidiChannelPressureMessage
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.Midi
{
  [Guid(3189745760, 25268, 19794, 163, 126, 146, 229, 77, 53, 185, 9)]
  [ExclusiveTo(typeof (MidiChannelPressureMessage))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IMidiChannelPressureMessage : IMidiMessage
  {
    byte Channel { get; }

    byte Pressure { get; }
  }
}