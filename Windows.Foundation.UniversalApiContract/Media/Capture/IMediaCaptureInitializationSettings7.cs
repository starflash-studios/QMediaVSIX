// Decompiled with JetBrains decompiler
// Type: Windows.Media.Capture.IMediaCaptureInitializationSettings7
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Security.Credentials;

namespace Windows.Media.Capture
{
  [Guid(1096051047, 62858, 23938, 158, 244, 237, 87, 47, 181, 227, 78)]
  [ExclusiveTo(typeof (MediaCaptureInitializationSettings))]
  [ContractVersion(typeof (UniversalApiContract), 655360)]
  internal interface IMediaCaptureInitializationSettings7
  {
    PasswordCredential DeviceUriPasswordCredential { get; set; }

    Uri DeviceUri { get; set; }
  }
}
