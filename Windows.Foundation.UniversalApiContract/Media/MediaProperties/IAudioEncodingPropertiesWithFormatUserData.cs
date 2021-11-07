// Decompiled with JetBrains decompiler
// Type: Windows.Media.MediaProperties.IAudioEncodingPropertiesWithFormatUserData
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Media.MediaProperties
{
  [ExclusiveTo(typeof (AudioEncodingProperties))]
  [Guid(2565934457, 5098, 18943, 190, 112, 38, 115, 219, 105, 112, 44)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IAudioEncodingPropertiesWithFormatUserData
  {
    void SetFormatUserData(byte[] value);

    void GetFormatUserData(out byte[] value);
  }
}
