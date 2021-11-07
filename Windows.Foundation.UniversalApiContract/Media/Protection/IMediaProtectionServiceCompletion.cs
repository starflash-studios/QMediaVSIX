// Decompiled with JetBrains decompiler
// Type: Windows.Media.Protection.IMediaProtectionServiceCompletion
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Media.Protection
{
  [ExclusiveTo(typeof (MediaProtectionServiceCompletion))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(2338114072, 53205, 17646, 162, 237, 223, 118, 1, 12, 20, 181)]
  internal interface IMediaProtectionServiceCompletion
  {
    void Complete(bool success);
  }
}
