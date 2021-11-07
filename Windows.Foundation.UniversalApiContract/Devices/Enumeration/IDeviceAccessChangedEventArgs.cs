// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Enumeration.IDeviceAccessChangedEventArgs
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.Enumeration
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(3738831820, 20381, 20312, 157, 186, 169, 188, 128, 4, 8, 213)]
  [ExclusiveTo(typeof (DeviceAccessChangedEventArgs))]
  internal interface IDeviceAccessChangedEventArgs
  {
    DeviceAccessStatus Status { get; }
  }
}
