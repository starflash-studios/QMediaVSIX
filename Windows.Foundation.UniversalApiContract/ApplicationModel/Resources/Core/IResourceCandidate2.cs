// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Resources.Core.IResourceCandidate2
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Storage.Streams;

namespace Windows.ApplicationModel.Resources.Core
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(1776661608, 63228, 16403, 170, 162, 213, 63, 23, 87, 211, 181)]
  [ExclusiveTo(typeof (ResourceCandidate))]
  internal interface IResourceCandidate2
  {
    [RemoteAsync]
    IAsyncOperation<IRandomAccessStream> GetValueAsStreamAsync();
  }
}
