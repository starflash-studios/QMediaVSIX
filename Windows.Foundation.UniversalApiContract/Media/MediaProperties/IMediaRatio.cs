// Decompiled with JetBrains decompiler
// Type: Windows.Media.MediaProperties.IMediaRatio
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Media.MediaProperties
{
  [ExclusiveTo(typeof (MediaRatio))]
  [Guid(3536912101, 35113, 16413, 172, 120, 125, 53, 126, 55, 129, 99)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IMediaRatio
  {
    uint Numerator { set; get; }

    uint Denominator { set; get; }
  }
}
