// Decompiled with JetBrains decompiler
// Type: Windows.Storage.Streams.IDataReaderFactory
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Storage.Streams
{
  [Guid(3612506183, 22490, 19989, 145, 76, 6, 128, 102, 153, 160, 152)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (DataReader))]
  internal interface IDataReaderFactory
  {
    DataReader CreateDataReader(IInputStream inputStream);
  }
}
