// Decompiled with JetBrains decompiler
// Type: Windows.Media.Core.IAudioStreamDescriptor
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Media.MediaProperties;

namespace Windows.Media.Core
{
  [Guid(506893028, 16423, 18503, 167, 11, 223, 29, 154, 42, 123, 4)]
  [ExclusiveTo(typeof (AudioStreamDescriptor))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IAudioStreamDescriptor : IMediaStreamDescriptor
  {
    AudioEncodingProperties EncodingProperties { get; }
  }
}
