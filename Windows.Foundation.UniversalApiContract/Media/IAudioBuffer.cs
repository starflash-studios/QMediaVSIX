// Decompiled with JetBrains decompiler
// Type: Windows.Media.IAudioBuffer
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Media
{
  [Guid(890722343, 29259, 19562, 177, 48, 246, 83, 127, 154, 224, 208)]
  [ExclusiveTo(typeof (AudioBuffer))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IAudioBuffer : IMemoryBuffer, IClosable
  {
    uint Capacity { get; }

    uint Length { get; set; }
  }
}
