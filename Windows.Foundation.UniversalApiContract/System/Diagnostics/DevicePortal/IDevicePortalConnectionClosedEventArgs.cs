// Decompiled with JetBrains decompiler
// Type: Windows.System.Diagnostics.DevicePortal.IDevicePortalConnectionClosedEventArgs
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.System.Diagnostics.DevicePortal
{
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  [Guid(4244049464, 28722, 17036, 159, 80, 148, 92, 21, 169, 240, 203)]
  [ExclusiveTo(typeof (DevicePortalConnectionClosedEventArgs))]
  internal interface IDevicePortalConnectionClosedEventArgs
  {
    DevicePortalConnectionClosedReason Reason { get; }
  }
}
