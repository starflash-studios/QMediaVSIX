// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Contacts.ContactAnnotationList
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Contacts
{
  /// <summary>Represents a list of ContactAnnotation objects.</summary>
  [MarshalingBehavior(MarshalingType.Agile)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public sealed class ContactAnnotationList : IContactAnnotationList
  {
    /// <summary>Gets the ID for this ContactAnnotationList.</summary>
    /// <returns>The ID for this ContactAnnotationList.</returns>
    public extern string Id { [MethodImpl] get; }

    /// <summary>Gets the unique identifier for the app package that created the ContactAnnotationList.</summary>
    /// <returns>The unique identifier for the app package that created the ContactAnnotationList.</returns>
    public extern string ProviderPackageFamilyName { [MethodImpl] get; }

    /// <summary>Gets the ID for the UserDataAccount used by the app.</summary>
    /// <returns>The ID for the UserDataAccount used by the app.</returns>
    public extern string UserDataAccountId { [MethodImpl] get; }

    /// <summary>Asynchronously deletes this ContactAnnotationList from the ContactAnnotationStore.</summary>
    /// <returns>An async action indicating that the operation has completed.</returns>
    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncAction DeleteAsync();

    /// <summary>Asynchronously attempts to save the ContactAnnotation to the ContactAnnotationList.</summary>
    /// <param name="annotation">The annotation to save to the list.</param>
    /// <returns>True if the save was successful, otherwise false.</returns>
    [MethodImpl]
    public extern IAsyncOperation<bool> TrySaveAnnotationAsync(
      ContactAnnotation annotation);

    /// <summary>Gets the ContactAnnotation with the specified Id.</summary>
    /// <param name="annotationId">The ContactAnnotation.Id used to identify the ContactAnnotation.</param>
    /// <returns>The ContactAnnotation with the specified ID.</returns>
    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperation<ContactAnnotation> GetAnnotationAsync(
      string annotationId);

    /// <summary>Gets the list of ContactAnnotation objects containing the specified remote ID property.</summary>
    /// <param name="remoteId">The remote ID used to find the ContactAnnotation objects.</param>
    /// <returns>The list of ContactAnnotation objects containing the specified remote ID property.</returns>
    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperation<IVectorView<ContactAnnotation>> FindAnnotationsByRemoteIdAsync(
      string remoteId);

    /// <summary>Asynchronously gets the list of ContactAnnotation objects.</summary>
    /// <returns>The list of ContactAnnotation objects.</returns>
    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperation<IVectorView<ContactAnnotation>> FindAnnotationsAsync();

    /// <summary>Asynchronously deletes the specified ContactAnnotation from the list.</summary>
    /// <param name="annotation">The annotation to delete from the list.</param>
    /// <returns>An async action indicating that the operation has completed.</returns>
    [MethodImpl]
    public extern IAsyncAction DeleteAnnotationAsync(ContactAnnotation annotation);
  }
}
