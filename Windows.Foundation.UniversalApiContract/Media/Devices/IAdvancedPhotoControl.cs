// Decompiled with JetBrains decompiler
// Type: Windows.Media.Devices.IAdvancedPhotoControl
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.Media.Devices
{
  [Guid(3316733062, 36865, 18050, 147, 9, 104, 234, 224, 8, 14, 236)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (AdvancedPhotoControl))]
  internal interface IAdvancedPhotoControl
  {
    bool Supported { get; }

    IVectorView<AdvancedPhotoMode> SupportedModes { get; }

    AdvancedPhotoMode Mode { get; }

    void Configure(AdvancedPhotoCaptureSettings settings);
  }
}
