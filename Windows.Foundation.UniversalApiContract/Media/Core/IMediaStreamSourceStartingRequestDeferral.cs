// Decompiled with JetBrains decompiler
// Type: Windows.Media.Core.IMediaStreamSourceStartingRequestDeferral
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Media.Core
{
  [Guid(1058231973, 25408, 19908, 153, 16, 6, 142, 217, 245, 152, 248)]
  [ExclusiveTo(typeof (MediaStreamSourceStartingRequestDeferral))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IMediaStreamSourceStartingRequestDeferral
  {
    void Complete();
  }
}
