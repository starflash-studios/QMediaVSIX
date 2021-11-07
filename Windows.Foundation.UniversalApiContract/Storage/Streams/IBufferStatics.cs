// Decompiled with JetBrains decompiler
// Type: Windows.Storage.Streams.IBufferStatics
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Storage.Streams
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(3909215835, 55062, 18266, 169, 10, 175, 114, 41, 177, 231, 65)]
  [ExclusiveTo(typeof (Buffer))]
  internal interface IBufferStatics
  {
    Buffer CreateCopyFromMemoryBuffer(IMemoryBuffer input);

    MemoryBuffer CreateMemoryBufferOverIBuffer(IBuffer input);
  }
}
