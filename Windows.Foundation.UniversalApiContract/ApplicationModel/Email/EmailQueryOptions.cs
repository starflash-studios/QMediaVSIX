// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Email.EmailQueryOptions
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Email
{
  /// <summary>Represents the options selected for an email mailbox query.</summary>
  [Activatable(typeof (IEmailQueryOptionsFactory), 65536, "Windows.Foundation.UniversalApiContract")]
  [Threading(ThreadingModel.Both)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [Activatable(65536, "Windows.Foundation.UniversalApiContract")]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public sealed class EmailQueryOptions : IEmailQueryOptions
  {
    /// <summary>Instantiates a new instance of the  class.</summary>
    /// <param name="text">The text for which to search.</param>
    [MethodImpl]
    public extern EmailQueryOptions(string text);

    /// <summary>Instantiates a new instance of the  class.</summary>
    /// <param name="text">The text for which to search.</param>
    /// <param name="fields">The fields against which to search.</param>
    [MethodImpl]
    public extern EmailQueryOptions(string text, EmailQuerySearchFields fields);

    /// <summary>Instantiates a new instance of the  class.</summary>
    [MethodImpl]
    public extern EmailQueryOptions();

    /// <summary>Gets the text to search for.</summary>
    /// <returns>The text to search for.</returns>
    public extern EmailQueryTextSearch TextSearch { [MethodImpl] get; }

    /// <summary>Gets or sets the direction of the sort for the query results.</summary>
    /// <returns>The direction of the sort for the query results.</returns>
    public extern EmailQuerySortDirection SortDirection { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets a Boolean value indicating whether the query results should be sorted.</summary>
    /// <returns>A Boolean value indicating whether the query results should be sorted.</returns>
    public extern EmailQuerySortProperty SortProperty { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets the kind of emails for which to query.</summary>
    /// <returns>The kind of emails for which to query.</returns>
    public extern EmailQueryKind Kind { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets the identifiers for the folders in which to search.</summary>
    /// <returns>The identifiers for the folders in which to search.</returns>
    public extern IVector<string> FolderIds { [MethodImpl] get; }
  }
}
