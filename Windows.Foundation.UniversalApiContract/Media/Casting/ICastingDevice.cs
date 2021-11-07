// Decompiled with JetBrains decompiler
// Type: Windows.Media.Casting.ICastingDevice
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Storage.Streams;

namespace Windows.Media.Casting
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(3732020355, 19011, 19153, 166, 210, 36, 146, 167, 150, 195, 242)]
  [ExclusiveTo(typeof (CastingDevice))]
  internal interface ICastingDevice
  {
    string Id { get; }

    string FriendlyName { get; }

    IRandomAccessStreamWithContentType Icon { get; }

    [RemoteAsync]
    IAsyncOperation<CastingPlaybackTypes> GetSupportedCastingPlaybackTypesAsync();

    CastingConnection CreateCastingConnection();
  }
}
