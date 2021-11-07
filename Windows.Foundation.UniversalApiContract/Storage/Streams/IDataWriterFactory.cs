// Decompiled with JetBrains decompiler
// Type: Windows.Storage.Streams.IDataWriterFactory
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Storage.Streams
{
  [ExclusiveTo(typeof (DataWriter))]
  [Guid(864839618, 35716, 19499, 156, 80, 123, 135, 103, 132, 122, 31)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IDataWriterFactory
  {
    DataWriter CreateDataWriter(IOutputStream outputStream);
  }
}
