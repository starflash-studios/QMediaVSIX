// Decompiled with JetBrains decompiler
// Type: Windows.Security.ExchangeActiveSyncProvisioning.IEasClientDeviceInformation2
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Security.ExchangeActiveSyncProvisioning
{
  [ExclusiveTo(typeof (EasClientDeviceInformation))]
  [Guid(4289943843, 47910, 19818, 129, 188, 22, 90, 238, 10, 215, 84)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IEasClientDeviceInformation2 : IEasClientDeviceInformation
  {
    string SystemHardwareVersion { get; }

    string SystemFirmwareVersion { get; }
  }
}
