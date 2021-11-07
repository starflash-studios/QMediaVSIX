// Decompiled with JetBrains decompiler
// Type: Windows.Media.Devices.IAdvancedPhotoCaptureSettings
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Media.Devices
{
  [Guid(150177338, 24, 17499, 147, 210, 100, 109, 28, 94, 208, 92)]
  [ExclusiveTo(typeof (AdvancedPhotoCaptureSettings))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IAdvancedPhotoCaptureSettings
  {
    AdvancedPhotoMode Mode { get; set; }
  }
}
