// Decompiled with JetBrains decompiler
// Type: Windows.Media.Audio.ICreateAudioDeviceInputNodeResult
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Media.Audio
{
  [ExclusiveTo(typeof (CreateAudioDeviceInputNodeResult))]
  [Guid(384747432, 7335, 16623, 145, 164, 211, 70, 224, 170, 27, 186)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface ICreateAudioDeviceInputNodeResult
  {
    AudioDeviceNodeCreationStatus Status { get; }

    AudioDeviceInputNode DeviceInputNode { get; }
  }
}
