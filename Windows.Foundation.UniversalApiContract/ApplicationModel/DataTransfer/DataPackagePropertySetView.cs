// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.DataTransfer.DataPackagePropertySetView
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
  /// <summary>Gets the set of properties of a DataPackageView object.</summary>
  [MarshalingBehavior(MarshalingType.Agile)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [DualApiPartition(version = 100794368)]
  public sealed class DataPackagePropertySetView : 
    IDataPackagePropertySetView,
    IDataPackagePropertySetView2,
    IDataPackagePropertySetView3,
    IDataPackagePropertySetView4,
    IDataPackagePropertySetView5,
    IMapView<string, object>,
    IIterable<IKeyValuePair<string, object>>
  {
    /// <summary>Gets the text that displays as a title for the contents of the DataPackagePropertySetView object.</summary>
    /// <returns>The text that displays as a title for the contents of the DataPackagePropertySetView object.</returns>
    public extern string Title { [MethodImpl] get; }

    /// <summary>Gets the text that describes the contents of the DataPackage.</summary>
    /// <returns>Text that describes the contents of the DataPackage.</returns>
    public extern string Description { [MethodImpl] get; }

    /// <summary>Gets the thumbnail image for the DataPackageView.</summary>
    /// <returns>The IRandomAccessStreamReference that represents the thumbnail image.</returns>
    public extern RandomAccessStreamReference Thumbnail { [MethodImpl] get; }

    /// <summary>Gets a vector object that contains the types of files stored in the DataPackage object.</summary>
    /// <returns>Contains the types of files stored in the DataPackage object.</returns>
    public extern IVectorView<string> FileTypes { [MethodImpl] get; }

    /// <summary>Gets the name of the app that created the DataPackage object.</summary>
    /// <returns>The name of the app that created the DataPackage object.</returns>
    public extern string ApplicationName { [MethodImpl] get; }

    /// <summary>Gets the Uniform Resource Identifier (URI) of the app's location in the Microsoft Store.</summary>
    /// <returns>The Uniform Resource Identifier (URI) of the app in the Microsoft Store.</returns>
    public extern Uri ApplicationListingUri { [MethodImpl] get; }

    /// <summary>Gets the package family name of the source app.</summary>
    /// <returns>The package family name.</returns>
    public extern string PackageFamilyName { [MethodImpl] get; }

    /// <summary>Gets a web link to shared content that's currently displayed in the app.</summary>
    /// <returns>The Uniform Resource Identifier (URI) of the web link to shared content.</returns>
    public extern Uri ContentSourceWebLink { [MethodImpl] get; }

    /// <summary>Gets the application link to the content from the source app.</summary>
    /// <returns>The Uniform Resource Identifier (URI) of the application link to shared content.</returns>
    public extern Uri ContentSourceApplicationLink { [MethodImpl] get; }

    /// <summary>Gets the source app's logo.</summary>
    /// <returns>The logo's bitmap.</returns>
    public extern IRandomAccessStreamReference Square30x30Logo { [MethodImpl] get; }

    /// <summary>Gets a background color for the sharing app's Square30x30Logo.</summary>
    /// <returns>The background color for the sharing app's Square30x30Logo.</returns>
    public extern Color LogoBackgroundColor { [MethodImpl] get; }

    /// <summary>Gets or sets the enterprise Id.</summary>
    /// <returns>The enterprise Id.</returns>
    public extern string EnterpriseId { [MethodImpl] get; }

    /// <summary>Gets the UserActivity in serialized JSON format to be shared with another app.</summary>
    /// <returns>The UserActivity in serialized JSON format to be shared with another app.</returns>
    public extern string ContentSourceUserActivityJson { [MethodImpl] get; }

    /// <summary>Gets a value that indicates whether the shared content in the DataPackageView comes from clipboard data that was synced from another device for the current user.</summary>
    /// <returns>True if the shared content in the DataPackageView comes from clipboard data that was synced from another device for the current user; otherwise, false.</returns>
    public extern bool IsFromRoamingClipboard { [MethodImpl] get; }

    [MethodImpl]
    public extern object Lookup(string key);

    public extern uint Size { [MethodImpl] get; }

    [MethodImpl]
    public extern bool HasKey(string key);

    [MethodImpl]
    public extern void Split(
      out IMapView<string, object> first,
      out IMapView<string, object> second);

    [MethodImpl]
    public extern IIterator<IKeyValuePair<string, object>> First();
  }
}
