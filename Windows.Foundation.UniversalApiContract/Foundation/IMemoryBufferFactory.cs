// Decompiled with JetBrains decompiler
// Type: Windows.Foundation.IMemoryBufferFactory
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation.Metadata;

namespace Windows.Foundation
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(4223982891, 9307, 4580, 175, 152, 104, 148, 35, 38, 12, 248)]
  [ExclusiveTo(typeof (MemoryBuffer))]
  internal interface IMemoryBufferFactory
  {
    MemoryBuffer Create([Range(0, 2147483647)] uint capacity);
  }
}
