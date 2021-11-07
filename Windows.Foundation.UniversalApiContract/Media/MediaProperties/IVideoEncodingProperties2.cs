// Decompiled with JetBrains decompiler
// Type: Windows.Media.MediaProperties.IVideoEncodingProperties2
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Media.MediaProperties
{
  [Guid(4148404719, 54373, 17040, 169, 75, 239, 15, 21, 40, 248, 227)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (VideoEncodingProperties))]
  internal interface IVideoEncodingProperties2
  {
    void SetFormatUserData(byte[] value);

    void GetFormatUserData(out byte[] value);

    int ProfileId { set; get; }
  }
}
