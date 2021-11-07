// Decompiled with JetBrains decompiler
// Type: Windows.Media.Casting.ICastingDevicePickerFilter
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.Media.Casting
{
  [ExclusiveTo(typeof (CastingDevicePickerFilter))]
  [Guid(3196871068, 46435, 17236, 174, 51, 159, 218, 173, 140, 98, 145)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface ICastingDevicePickerFilter
  {
    bool SupportsAudio { get; set; }

    bool SupportsVideo { get; set; }

    bool SupportsPictures { get; set; }

    IVector<CastingSource> SupportedCastingSources { get; }
  }
}
