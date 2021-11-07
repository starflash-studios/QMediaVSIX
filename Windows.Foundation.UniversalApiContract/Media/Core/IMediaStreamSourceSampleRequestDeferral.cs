// Decompiled with JetBrains decompiler
// Type: Windows.Media.Core.IMediaStreamSourceSampleRequestDeferral
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Media.Core
{
  [ExclusiveTo(typeof (MediaStreamSourceSampleRequestDeferral))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(2023083010, 63874, 17352, 157, 22, 198, 45, 153, 147, 25, 190)]
  internal interface IMediaStreamSourceSampleRequestDeferral
  {
    void Complete();
  }
}
