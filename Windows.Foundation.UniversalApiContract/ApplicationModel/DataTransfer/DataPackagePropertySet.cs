// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.DataTransfer.DataPackagePropertySet
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
using Windows.Storage.Streams;
using Windows.UI;

namespace Windows.ApplicationModel.DataTransfer
{
  /// <summary>Defines a set of properties to use with a DataPackage object.</summary>
  [DualApiPartition(version = 100794368)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public sealed class DataPackagePropertySet : 
    IDataPackagePropertySet,
    IMap<string, object>,
    IIterable<IKeyValuePair<string, object>>,
    IDataPackagePropertySet2,
    IDataPackagePropertySet3,
    IDataPackagePropertySet4
  {
    /// <summary>Gets or sets the text that displays as a title for the contents of the DataPackage object.</summary>
    /// <returns>The text that displays as a title for the contents of the DataPackage object.</returns>
    public extern string Title { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets text that describes the contents of the DataPackage.</summary>
    /// <returns>Text that describes the contents of the DataPackage.</returns>
    public extern string Description { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets a thumbnail image for the DataPackage.</summary>
    /// <returns>The IRandomAccessStreamReference that represents the thumbnail image.</returns>
    public extern IRandomAccessStreamReference Thumbnail { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Specifies a vector object that contains the types of files stored in the DataPackage object.</summary>
    /// <returns>Contains the types of files stored in the DataPackage object.</returns>
    public extern IVector<string> FileTypes { [MethodImpl] get; }

    /// <summary>Gets or sets the name of the app that created the DataPackage object.</summary>
    /// <returns>Specifies the name of the app that created the DataPackage object.</returns>
    public extern string ApplicationName { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets the Uniform Resource Identifier (URI) of the app's location in the Windows Store.</summary>
    /// <returns>The Uniform Resource Identifier (URI) of the app in the Windows Store.</returns>
    public extern Uri ApplicationListingUri { [MethodImpl] get; [MethodImpl] set; }

    [MethodImpl]
    public extern object Lookup(string key);

    public extern uint Size { [MethodImpl] get; }

    [MethodImpl]
    public extern bool HasKey(string key);

    [MethodImpl]
    public extern IMapView<string, object> GetView();

    [MethodImpl]
    public extern bool Insert(string key, object value);

    [MethodImpl]
    public extern void Remove(string key);

    [MethodImpl]
    public extern void Clear();

    [MethodImpl]
    public extern IIterator<IKeyValuePair<string, object>> First();

    /// <summary>Provides a web link to shared content that's currently displayed in the app.</summary>
    /// <returns>The Uniform Resource Identifier (URI) of the web link to shared content.</returns>
    public extern Uri ContentSourceWebLink { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets the application link to the content from the source app.</summary>
    /// <returns>The Uniform Resource Identifier (URI) of the application link to shared content.</returns>
    public extern Uri ContentSourceApplicationLink { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets the package family name of the source app.</summary>
    /// <returns>The package family name.</returns>
    public extern string PackageFamilyName { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets the source app's logo.</summary>
    /// <returns>The logo's bitmap.</returns>
    public extern IRandomAccessStreamReference Square30x30Logo { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets a background color for the sharing app's Square30x30Logo.</summary>
    /// <returns>The color of the logo's background.</returns>
    public extern Color LogoBackgroundColor { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets the enterprise identity (see Enterprise data protection ).</summary>
    /// <returns>The enterprise Id.</returns>
    public extern string EnterpriseId { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets the UserActivity in serialized JSON format to be shared with another app.</summary>
    /// <returns>The UserActivity in serialized JSON format to be shared with another app.</returns>
    public extern string ContentSourceUserActivityJson { [MethodImpl] get; [MethodImpl] set; }
  }
}
