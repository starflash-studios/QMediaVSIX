// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.DataTransfer.DataPackageView
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
using Windows.Security.EnterpriseData;
using Windows.Storage;
using Windows.Storage.Streams;

namespace Windows.ApplicationModel.DataTransfer
{
  /// <summary>A read-only version of a DataPackage. Apps that receive shared content get this object when acquiring content.</summary>
  [DualApiPartition(version = 100794368)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public sealed class DataPackageView : 
    IDataPackageView,
    IDataPackageView2,
    IDataPackageView3,
    IDataPackageView4
  {
    /// <summary>Gets a DataPackagePropertySetView object, which contains a read-only set of properties for the data in the DataPackageView object.</summary>
    /// <returns>The object that contains a read-only set of properties for the data.</returns>
    public extern DataPackagePropertySetView Properties { [MethodImpl] get; }

    /// <summary>Gets the requested operation (such as copy or move). Primarily used for Clipboard actions.</summary>
    /// <returns>An enumeration that states what operation (such as copy or move) was completed.</returns>
    public extern DataPackageOperation RequestedOperation { [MethodImpl] get; }

    /// <summary>Informs the system that your app is finished using the DataPackageView object. Primarily used for Clipboard operations.</summary>
    /// <param name="value">An enumeration that states what operation (such as copy or move) was completed. At most one operation flag can be set.</param>
    [MethodImpl]
    public extern void ReportOperationCompleted(DataPackageOperation value);

    /// <summary>Returns the formats the DataPackageView contains.</summary>
    /// <returns>The formats the DataPackageView contains.</returns>
    public extern IVectorView<string> AvailableFormats { [MethodImpl] get; }

    /// <summary>Checks to see if the DataPackageView contains a specific data format.</summary>
    /// <param name="formatId">The name of the format.</param>
    /// <returns>True if the DataPackageView contains the format; false otherwise.</returns>
    [MethodImpl]
    public extern bool Contains(string formatId);

    /// <summary>Gets the data contained in the DataPackageView.</summary>
    /// <param name="formatId">Specifies the format of the data. We recommend that you set this value by using the StandardDataFormats class.</param>
    /// <returns>The data.</returns>
    [RemoteAsync]
    [MethodImpl]
    [return: HasVariant]
    public extern IAsyncOperation<object> GetDataAsync(string formatId);

    /// <summary>Gets the text in the DataPackageView object.</summary>
    /// <returns>The text.</returns>
    [Overload("GetTextAsync")]
    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperation<string> GetTextAsync();

    /// <summary>Gets the text in the DataPackageView object.</summary>
    /// <param name="formatId">A string that represents the data format. Usually StandardDataFormats.text.</param>
    /// <returns>The text.</returns>
    [Overload("GetCustomTextAsync")]
    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperation<string> GetTextAsync(string formatId);

    /// <summary>Gets the URI contained in the DataPackageView.</summary>
    /// <deprecated type="deprecate">GetUriAsync may be altered or unavailable for releases after Windows 8.1. Instead, use GetWebLinkAsync or GetApplicationLinkAsync.</deprecated>
    /// <returns>The Uri.</returns>
    [Deprecated("GetUriAsync may be altered or unavailable for releases after Windows 8.1. Instead, use GetWebLinkAsync or GetApplicationLinkAsync.", DeprecationType.Deprecate, 65536, "Windows.Foundation.UniversalApiContract")]
    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperation<Uri> GetUriAsync();

    /// <summary>Gets the HTML stored in the DataPackageView object.</summary>
    /// <returns>The HTML.</returns>
    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperation<string> GetHtmlFormatAsync();

    /// <summary>Gets the data (such as an image) referenced in HTML content.</summary>
    /// <returns>The data referenced in the HTML content.</returns>
    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperation<IMapView<string, RandomAccessStreamReference>> GetResourceMapAsync();

    /// <summary>Gets the rich text formatted (RTF) content contained in a DataPackageView.</summary>
    /// <returns>The rich text formatted content for the DataPackage.</returns>
    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperation<string> GetRtfAsync();

    /// <summary>Gets the bitmap image contained in the DataPackageView</summary>
    /// <returns>A stream containing the bitmap image.</returns>
    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperation<RandomAccessStreamReference> GetBitmapAsync();

    /// <summary>Gets the files and folders stored in a DataPackageView object.</summary>
    /// <returns>An array of files and folders stored in a DataPackageView.</returns>
    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperation<IVectorView<IStorageItem>> GetStorageItemsAsync();

    /// <summary>Gets the application link in the DataPackageView object.</summary>
    /// <returns>The application link.</returns>
    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperation<Uri> GetApplicationLinkAsync();

    /// <summary>Gets the web link in the DataPackageView object.</summary>
    /// <returns>The web link.</returns>
    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperation<Uri> GetWebLinkAsync();

    /// <summary>Requests permission to unlock and access a data package that is secured with a protection policy.</summary>
    /// <returns>When this method completes, it returns the results of the protection policy evaluation, which indicates whether or not the data is accessible.</returns>
    [Overload("RequestAccessAsync")]
    [MethodImpl]
    public extern IAsyncOperation<ProtectionPolicyEvaluationResult> RequestAccessAsync();

    /// <summary>Requests permission to unlock and access a data package that is secured with a protection policy.</summary>
    /// <param name="enterpriseId">The enterprise Id.</param>
    /// <returns>When this method completes, it returns the results of the protection policy evaluation, which indicates whether or not the data is accessible.</returns>
    [Overload("RequestAccessWithEnterpriseIdAsync")]
    [MethodImpl]
    public extern IAsyncOperation<ProtectionPolicyEvaluationResult> RequestAccessAsync(
      string enterpriseId);

    /// <summary>Unlocks a data package and assumes an enterprise identity for it.</summary>
    /// <returns>When this method completes, it returns the results of the protection policy evaluation.</returns>
    [MethodImpl]
    public extern ProtectionPolicyEvaluationResult UnlockAndAssumeEnterpriseIdentity();

    /// <summary>Sets the accepted format Id.</summary>
    /// <param name="formatId">The format Id.</param>
    [MethodImpl]
    public extern void SetAcceptedFormatId(string formatId);
  }
}
