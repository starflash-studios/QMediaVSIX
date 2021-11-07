// Decompiled with JetBrains decompiler
// Type: Windows.Media.MediaProperties.ITimedMetadataEncodingProperties
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Media.MediaProperties
{
  [ContractVersion(typeof (UniversalApiContract), 393216)]
  [Guid(1372401875, 54928, 19706, 151, 244, 74, 57, 142, 157, 180, 32)]
  [ExclusiveTo(typeof (TimedMetadataEncodingProperties))]
  internal interface ITimedMetadataEncodingProperties
  {
    void SetFormatUserData(byte[] value);

    void GetFormatUserData(out byte[] value);

    TimedMetadataEncodingProperties Copy();
  }
}
