// Decompiled with JetBrains decompiler
// Type: Windows.Storage.Streams.IDataReaderStatics
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Storage.Streams
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (DataReader))]
  [Guid(301776840, 63802, 18203, 177, 33, 243, 121, 227, 73, 49, 60)]
  internal interface IDataReaderStatics
  {
    DataReader FromBuffer(IBuffer buffer);
  }
}
