// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.DataTransfer.IDataPackagePropertySet
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
using Windows.Storage.Streams;

namespace Windows.ApplicationModel.DataTransfer
{
  [Guid(3441202155, 19532, 17466, 168, 211, 245, 194, 65, 233, 22, 137)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [HasVariant]
  [ExclusiveTo(typeof (DataPackagePropertySet))]
  internal interface IDataPackagePropertySet : 
    IMap<string, object>,
    IIterable<IKeyValuePair<string, object>>
  {
    string Title { get; set; }

    string Description { get; set; }

    IRandomAccessStreamReference Thumbnail { get; set; }

    IVector<string> FileTypes { get; }

    string ApplicationName { get; set; }

    Uri ApplicationListingUri { get; set; }
  }
}
