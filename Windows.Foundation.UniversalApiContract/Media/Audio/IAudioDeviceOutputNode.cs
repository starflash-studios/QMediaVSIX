// Decompiled with JetBrains decompiler
// Type: Windows.Media.Audio.IAudioDeviceOutputNode
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Devices.Enumeration;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Media.Audio
{
  [Guid(909040639, 65308, 17460, 158, 15, 189, 46, 245, 34, 172, 130)]
  [ExclusiveTo(typeof (AudioDeviceOutputNode))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IAudioDeviceOutputNode : IAudioNode, IClosable
  {
    DeviceInformation Device { get; }
  }
}
