// Decompiled with JetBrains decompiler
// Type: Windows.Media.Audio.IAudioDeviceInputNode
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Devices.Enumeration;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Media.Audio
{
  [ExclusiveTo(typeof (AudioDeviceInputNode))]
  [Guid(2954587105, 28494, 18914, 172, 1, 85, 157, 98, 190, 179, 169)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IAudioDeviceInputNode : IAudioInputNode, IAudioNode, IClosable
  {
    DeviceInformation Device { get; }
  }
}
