// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Search.LocalContentSuggestionSettings
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
using Windows.Storage;

namespace Windows.ApplicationModel.Search
{
  /// <summary>Stores settings that determine whether the app provides suggestions based on local files, and that define the criteria used to locate and filter these suggestions.</summary>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Activatable(65536, "Windows.Foundation.UniversalApiContract")]
  [MarshalingBehavior(MarshalingType.Standard)]
  public sealed class LocalContentSuggestionSettings : ILocalContentSuggestionSettings
  {
    /// <summary>Creates a new instance of the localContentSuggestionSettings class.</summary>
    [MethodImpl]
    public extern LocalContentSuggestionSettings();

    /// <summary>Indicates whether suggestions based on local files are displayed in the search pane.</summary>
    /// <returns>True if suggestions from local files are displayed; otherwise, false. The default value of the object is false.</returns>
    public extern bool Enabled { [MethodImpl] set; [MethodImpl] get; }

    /// <summary>A list of the storageFolder objects that contain files that are used to provide suggestions. If the list is empty, suggestions are provided from files in all of the local libraries for which the app declared capabilities.</summary>
    /// <returns>The list of storageFolder locations that contain files that are used to provide suggestions. By default, this list is empty and suggestions are provided from the local files in all of the libraries for which the app declared capabilities.</returns>
    public extern IVector<StorageFolder> Locations { [MethodImpl] get; }

    /// <summary>An Advanced Query Syntax (AQS) string that limits the types and kinds of files that are used to provide suggestions. If no Advanced Query Syntax (AQS) string is specified, suggestions are provided from all local files in locations specified by the locations property.</summary>
    /// <returns>The Advanced Query Syntax (AQS) string that is used to refine which local, indexed files are used to provide suggestions. By default, this string is empty. Learn more about Advanced Query Syntax (AQS) in .</returns>
    public extern string AqsFilter { [MethodImpl] set; [MethodImpl] get; }

    /// <summary>A list of the file properties whose values are used to provide suggestions from local files. If the list is empty, all of the file properties that are available for suggestions are used.</summary>
    /// <returns>The list of the file properties that are used to provide suggestions from local files. By default, this list is empty and all of the file properties that are available for suggestions are used.</returns>
    public extern IVector<string> PropertiesToMatch { [MethodImpl] get; }
  }
}
