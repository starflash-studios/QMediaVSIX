﻿// Decompiled with JetBrains decompiler
// Type: Windows.Media.Audio.ICreateAudioDeviceOutputNodeResult
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Media.Audio
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (CreateAudioDeviceOutputNodeResult))]
  [Guid(4151799079, 7578, 18423, 156, 212, 40, 89, 204, 27, 123, 255)]
  internal interface ICreateAudioDeviceOutputNodeResult
  {
    AudioDeviceNodeCreationStatus Status { get; }

    AudioDeviceOutputNode DeviceOutputNode { get; }
  }
}