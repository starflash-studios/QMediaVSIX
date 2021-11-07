// Decompiled with JetBrains decompiler
// Type: Windows.Media.Core.IDataCue
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Storage.Streams;

namespace Windows.Media.Core
{
  [Guid(2088724333, 8124, 20013, 154, 135, 238, 56, 189, 29, 198, 55)]
  [ExclusiveTo(typeof (DataCue))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IDataCue : IMediaCue
  {
    IBuffer Data { set; get; }
  }
}
