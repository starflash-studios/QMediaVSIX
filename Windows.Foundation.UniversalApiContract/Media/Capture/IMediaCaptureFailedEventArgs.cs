// Decompiled with JetBrains decompiler
// Type: Windows.Media.Capture.IMediaCaptureFailedEventArgs
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Media.Capture
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (MediaCaptureFailedEventArgs))]
  [Guid(2164122612, 21700, 17088, 141, 25, 206, 161, 168, 124, 161, 139)]
  internal interface IMediaCaptureFailedEventArgs
  {
    string Message { get; }

    uint Code { get; }
  }
}
