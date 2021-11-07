// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.DataTransfer.IDataPackageView
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
using Windows.Storage;
using Windows.Storage.Streams;

namespace Windows.ApplicationModel.DataTransfer
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(2072249457, 22784, 19845, 169, 11, 16, 203, 133, 254, 53, 82)]
  [ExclusiveTo(typeof (DataPackageView))]
  internal interface IDataPackageView
  {
    DataPackagePropertySetView Properties { get; }

    DataPackageOperation RequestedOperation { get; }

    void ReportOperationCompleted(DataPackageOperation value);

    IVectorView<string> AvailableFormats { get; }

    bool Contains(string formatId);

    [RemoteAsync]
    [return: HasVariant]
    IAsyncOperation<object> GetDataAsync(string formatId);

    [RemoteAsync]
    [Overload("GetTextAsync")]
    IAsyncOperation<string> GetTextAsync();

    [Overload("GetCustomTextAsync")]
    [RemoteAsync]
    IAsyncOperation<string> GetTextAsync(string formatId);

    [RemoteAsync]
    [Deprecated("GetUriAsync may be altered or unavailable for releases after Windows 8.1. Instead, use GetWebLinkAsync or GetApplicationLinkAsync.", DeprecationType.Deprecate, 65536, "Windows.Foundation.UniversalApiContract")]
    IAsyncOperation<Uri> GetUriAsync();

    [RemoteAsync]
    IAsyncOperation<string> GetHtmlFormatAsync();

    [RemoteAsync]
    IAsyncOperation<IMapView<string, RandomAccessStreamReference>> GetResourceMapAsync();

    [RemoteAsync]
    IAsyncOperation<string> GetRtfAsync();

    [RemoteAsync]
    IAsyncOperation<RandomAccessStreamReference> GetBitmapAsync();

    [RemoteAsync]
    IAsyncOperation<IVectorView<IStorageItem>> GetStorageItemsAsync();
  }
}
