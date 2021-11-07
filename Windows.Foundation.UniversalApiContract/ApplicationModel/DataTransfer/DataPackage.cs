// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.DataTransfer.DataPackage
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
using Windows.Storage;
using Windows.Storage.Streams;

namespace Windows.ApplicationModel.DataTransfer
{
  /// <summary>Contains the data that a user wants to exchange with another app.</summary>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Threading(ThreadingModel.Both)]
  [DualApiPartition(version = 100794368)]
  [Activatable(65536, "Windows.Foundation.UniversalApiContract")]
  [MarshalingBehavior(MarshalingType.Agile)]
  public sealed class DataPackage : IDataPackage, IDataPackage2, IDataPackage3, IDataPackage4
  {
    /// <summary>Constructor that creates a new DataPackage.</summary>
    [MethodImpl]
    public extern DataPackage();

    /// <summary>Returns a DataPackageView object. This object is a read-only copy of the DataPackage object.</summary>
    /// <returns>The object that is a read-only copy of the DataPackage object.</returns>
    [MethodImpl]
    public extern DataPackageView GetView();

    /// <summary>Allows you to get and set properties like the title of the content being shared.</summary>
    /// <returns>A collection of properties that describe the data contained in a DataPackage.</returns>
    public extern DataPackagePropertySet Properties { [MethodImpl] get; }

    /// <summary>Specifies the DataPackageOperation (none, move, copy, or link) for the operation.</summary>
    /// <returns>The operation requested by the source app.</returns>
    public extern DataPackageOperation RequestedOperation { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Occurs when a paste operation is completed.</summary>
    public extern event TypedEventHandler<DataPackage, OperationCompletedEventArgs> OperationCompleted;

    /// <summary>Occurs when the DataPackage is destroyed.</summary>
    public extern event TypedEventHandler<DataPackage, object> Destroyed;

    /// <summary>Sets the data contained in the DataPackage in a RandomAccessStream format.</summary>
    /// <param name="formatId">Specifies the format of the data. We recommend that you set this value by using the StandardDataFormats class.</param>
    /// <param name="value">Specifies the content that the DataPackage contains.</param>
    [MethodImpl]
    public extern void SetData(string formatId, [HasVariant] object value);

    /// <summary>Sets a delegate to handle requests from the target app.</summary>
    /// <param name="formatId">Specifies the format of the data. We recommend that you set this value by using the StandardDataFormats class.</param>
    /// <param name="delayRenderer">A delegate that is responsible for processing requests from a target app.</param>
    [MethodImpl]
    public extern void SetDataProvider(string formatId, DataProviderHandler delayRenderer);

    /// <summary>Sets the text that a DataPackage contains.</summary>
    /// <param name="value">The text.</param>
    [MethodImpl]
    public extern void SetText(string value);

    [Deprecated("SetUri may be altered or unavailable for releases after Windows Phone 'OSVersion' (TBD).Instead, use SetWebLink or SetApplicationLink.", DeprecationType.Deprecate, 65536, "Windows.Foundation.UniversalApiContract")]
    [MethodImpl]
    public extern void SetUri(Uri value);

    /// <summary>Adds HTML content to the DataPackage.</summary>
    /// <param name="value">The HTML content.</param>
    [MethodImpl]
    public extern void SetHtmlFormat(string value);

    /// <summary>Maps a URI to a file. Used to ensure that referenced content (such as an image) in HTML content is added to the DataPackage.</summary>
    /// <returns>Specifies a name/value pair that specifies the an HTML path with a corresponding StreamReference object.</returns>
    public extern IMap<string, RandomAccessStreamReference> ResourceMap { [MethodImpl] get; }

    /// <summary>Sets the Rich Text Format (RTF) content that is contained in a DataPackage.</summary>
    /// <param name="value">Specifies the Rich Text Format (RTF) content for the DataPackage.</param>
    [MethodImpl]
    public extern void SetRtf(string value);

    /// <summary>Sets the bitmap image contained in the DataPackage.</summary>
    /// <param name="value">A stream that contains the bitmap image.</param>
    [MethodImpl]
    public extern void SetBitmap(RandomAccessStreamReference value);

    [Overload("SetStorageItemsReadOnly")]
    [MethodImpl]
    public extern void SetStorageItems(IIterable<IStorageItem> value);

    [Overload("SetStorageItems")]
    [MethodImpl]
    public extern void SetStorageItems(IIterable<IStorageItem> value, bool readOnly);

    [MethodImpl]
    public extern void SetApplicationLink(Uri value);

    [MethodImpl]
    public extern void SetWebLink(Uri value);

    /// <summary>An event that is triggered when a share is completed. Shares can be sent to an app, a provider, or a contact.</summary>
    public extern event TypedEventHandler<DataPackage, ShareCompletedEventArgs> ShareCompleted;

    /// <summary>Raised when a share is canceled.</summary>
    public extern event TypedEventHandler<DataPackage, object> ShareCanceled;
  }
}
