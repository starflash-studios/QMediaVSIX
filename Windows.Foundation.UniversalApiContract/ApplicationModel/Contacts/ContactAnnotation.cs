// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Contacts.ContactAnnotation
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Contacts
{
  /// <summary>Provides a way to tag existing user contacts with additional information, specifying that your app can perform some SupportedOperations for this particular contact.</summary>
  [Activatable(65536, "Windows.Foundation.UniversalApiContract")]
  [MarshalingBehavior(MarshalingType.Agile)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public sealed class ContactAnnotation : IContactAnnotation, IContactAnnotation2
  {
    /// <summary>Initializes a new instance of the ContactAnnotation class.</summary>
    [MethodImpl]
    public extern ContactAnnotation();

    /// <summary>Gets the ID for this ContactAnnotation.</summary>
    /// <returns>The ID for this ContactAnnotation.</returns>
    public extern string Id { [MethodImpl] get; }

    /// <summary>Gets the ID for the parent ContactAnnotationList that this ContactAnnotation is contained within.</summary>
    /// <returns>The ID for the parent ContactAnnotationList that this ContactAnnotation is contained within.</returns>
    public extern string AnnotationListId { [MethodImpl] get; }

    /// <summary>Gets or set the ID for the Contact to which this ContactAnnotation applies.</summary>
    /// <returns>The ID for the Contact to which this ContactAnnotation applies.</returns>
    public extern string ContactId { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets an ID that can be used by a service provider to access the corresponding entity in their remote system.</summary>
    /// <returns>An ID that can be used by a service provider to access the corresponding entity in their remote system.</returns>
    public extern string RemoteId { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets the group of ContactAnnotationOperations supported by this ContactAnnotation.</summary>
    /// <returns>The group of ContactAnnotationOperations supported by this ContactAnnotation.</returns>
    public extern ContactAnnotationOperations SupportedOperations { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets a Boolean value indicating if this ContactAnnotation has been disabled by the user.</summary>
    /// <returns>Boolean value indicating if this ContactAnnotation has been disabled by the user.</returns>
    public extern bool IsDisabled { [MethodImpl] get; }

    /// <summary>Provides a place to store data to be used by the app when interacting with a service provider.</summary>
    /// <returns>Data to be used by the app when interacting with a service provider.</returns>
    public extern ValueSet ProviderProperties { [MethodImpl] get; }

    /// <summary>Gets or sets the ContactList to which this ContactAnnotation applies.</summary>
    /// <returns>The ID for the ContactList to which this ContactAnnotation applies.</returns>
    public extern string ContactListId { [MethodImpl] get; [MethodImpl] set; }
  }
}
