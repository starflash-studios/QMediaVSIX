// Decompiled with JetBrains decompiler
// Type: Windows.Media.Capture.IAppCaptureStatics2
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Media.Capture
{
  [ContractVersion(typeof (UniversalApiContract), 327680)]
  [Guid(3000533460, 33644, 19876, 175, 215, 250, 204, 4, 30, 28, 243)]
  [ExclusiveTo(typeof (AppCapture))]
  internal interface IAppCaptureStatics2
  {
    [RemoteAsync]
    IAsyncAction SetAllowedAsync(bool allowed);
  }
}
