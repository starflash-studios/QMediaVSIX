// Decompiled with JetBrains decompiler
// Type: Windows.Graphics.Capture.IGraphicsCaptureAccessStatics
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Security.Authorization.AppCapabilityAccess;

namespace Windows.Graphics.Capture
{
  [WebHostHidden]
  [ContractVersion(typeof (UniversalApiContract), 786432)]
  [Guid(1950274416, 1772, 20544, 165, 138, 144, 31, 15, 117, 112, 149)]
  [ExclusiveTo(typeof (GraphicsCaptureAccess))]
  internal interface IGraphicsCaptureAccessStatics
  {
    [RemoteAsync]
    IAsyncOperation<AppCapabilityAccessStatus> RequestAccessAsync(
      GraphicsCaptureAccessKind request);
  }
}
