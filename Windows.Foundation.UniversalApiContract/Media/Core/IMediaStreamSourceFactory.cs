// Decompiled with JetBrains decompiler
// Type: Windows.Media.Core.IMediaStreamSourceFactory
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Media.Core
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (MediaStreamSource))]
  [Guid(4017610969, 53592, 19322, 134, 63, 32, 51, 66, 251, 253, 65)]
  internal interface IMediaStreamSourceFactory
  {
    MediaStreamSource CreateFromDescriptor(IMediaStreamDescriptor descriptor);

    MediaStreamSource CreateFromDescriptors(
      IMediaStreamDescriptor descriptor,
      IMediaStreamDescriptor descriptor2);
  }
}
