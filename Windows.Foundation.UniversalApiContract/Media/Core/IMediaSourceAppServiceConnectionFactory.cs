// Decompiled with JetBrains decompiler
// Type: Windows.Media.Core.IMediaSourceAppServiceConnectionFactory
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.ApplicationModel.AppService;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Media.Core
{
  [ContractVersion(typeof (UniversalApiContract), 327680)]
  [ExclusiveTo(typeof (MediaSourceAppServiceConnection))]
  [Guid(1706627819, 32953, 17657, 156, 30, 225, 32, 246, 217, 40, 56)]
  internal interface IMediaSourceAppServiceConnectionFactory
  {
    MediaSourceAppServiceConnection Create(
      AppServiceConnection appServiceConnection);
  }
}
