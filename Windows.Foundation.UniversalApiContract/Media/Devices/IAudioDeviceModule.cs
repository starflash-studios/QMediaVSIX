// Decompiled with JetBrains decompiler
// Type: Windows.Media.Devices.IAudioDeviceModule
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Storage.Streams;

namespace Windows.Media.Devices
{
  [Guid(2261756982, 18369, 19251, 152, 82, 135, 115, 236, 75, 225, 35)]
  [ExclusiveTo(typeof (AudioDeviceModule))]
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  internal interface IAudioDeviceModule
  {
    string ClassId { get; }

    string DisplayName { get; }

    uint InstanceId { get; }

    uint MajorVersion { get; }

    uint MinorVersion { get; }

    [RemoteAsync]
    IAsyncOperation<ModuleCommandResult> SendCommandAsync(
      IBuffer Command);
  }
}
