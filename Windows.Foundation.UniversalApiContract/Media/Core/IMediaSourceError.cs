// Decompiled with JetBrains decompiler
// Type: Windows.Media.Core.IMediaSourceError
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Media.Core
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(1544194405, 14277, 20125, 141, 33, 28, 222, 233, 12, 236, 198)]
  [ExclusiveTo(typeof (MediaSourceError))]
  internal interface IMediaSourceError
  {
    HResult ExtendedError { get; }
  }
}
