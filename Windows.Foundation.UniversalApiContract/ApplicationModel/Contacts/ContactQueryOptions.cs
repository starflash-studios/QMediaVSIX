// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Contacts.ContactQueryOptions
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Contacts
{
  /// <summary>Used to specify the query options when searching for contacts.</summary>
  [MarshalingBehavior(MarshalingType.Agile)]
  [Activatable(typeof (IContactQueryOptionsFactory), 65536, "Windows.Foundation.UniversalApiContract")]
  [Activatable(65536, "Windows.Foundation.UniversalApiContract")]
  [Threading(ThreadingModel.Both)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public sealed class ContactQueryOptions : IContactQueryOptions
  {
    /// <summary>Initializes a new instance of the ContactQueryOptions class.</summary>
    /// <param name="text">The text to match in the search operation.</param>
    [MethodImpl]
    public extern ContactQueryOptions(string text);

    /// <summary>Initializes a new instance of the ContactQueryOptions class.</summary>
    /// <param name="text">The text to match in the search operation.</param>
    /// <param name="fields">Specifies which contact fields to search for a match.</param>
    [MethodImpl]
    public extern ContactQueryOptions(string text, ContactQuerySearchFields fields);

    /// <summary>Initializes a new instance of the ContactQueryOptions class.</summary>
    [MethodImpl]
    public extern ContactQueryOptions();

    /// <summary>Gets a ContactQueryTextSearch object that can be used for text searches.</summary>
    /// <returns>A ContactQueryTextSearch object that can be used for text searches.</returns>
    public extern ContactQueryTextSearch TextSearch { [MethodImpl] get; }

    /// <summary>Gets a list to which you can add ContactList.Id values for which to search.</summary>
    /// <returns>A list to which you can add ContactList.Id values for which to search.</returns>
    public extern IVector<string> ContactListIds { [MethodImpl] get; }

    /// <summary>Gets or sets a Boolean value indicating if the query results should include contacts from lists that are not shown in the user interface.</summary>
    /// <returns>A Boolean value indicating if the query results should include contacts from lists that are not shown in the user interface.</returns>
    public extern bool IncludeContactsFromHiddenLists { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets the desired fields a contact must have to match the query.</summary>
    /// <returns>The desired fields a contact must have to match the query.</returns>
    public extern ContactQueryDesiredFields DesiredFields { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets the desired annotation operations a contact must have to match the query.</summary>
    /// <returns>The desired annotation operations a contact must have to match the query.</returns>
    public extern ContactAnnotationOperations DesiredOperations { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets a list to which you can add ContactAnnotationList.Id values for which to search.</summary>
    /// <returns>A list to which you can add ContactAnnotationList.Id values for which to search.</returns>
    public extern IVector<string> AnnotationListIds { [MethodImpl] get; }
  }
}
