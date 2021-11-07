// Decompiled with JetBrains decompiler
// Type: Windows.System.Diagnostics.DevicePortal.IDevicePortalConnectionRequestReceivedEventArgs
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Web.Http;

namespace Windows.System.Diagnostics.DevicePortal
{
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  [ExclusiveTo(typeof (DevicePortalConnectionRequestReceivedEventArgs))]
  [Guid(1692065861, 28634, 17497, 158, 189, 236, 206, 34, 227, 133, 89)]
  internal interface IDevicePortalConnectionRequestReceivedEventArgs
  {
    HttpRequestMessage RequestMessage { get; }

    HttpResponseMessage ResponseMessage { get; }
  }
}
