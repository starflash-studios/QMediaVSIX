// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Contacts.ContactInformation
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
using Windows.Storage.Streams;

namespace Windows.ApplicationModel.Contacts
{
  /// <summary>Contains the information about a contact.</summary>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public sealed class ContactInformation : IContactInformation
  {
    /// <summary>The name of the contact.</summary>
    /// <returns>The name.</returns>
    public extern string Name { [MethodImpl] get; }

    /// <summary>Gets the thumbnail image for the contact.</summary>
    /// <returns>An object that provides access to the thumbnail image.</returns>
    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperation<IRandomAccessStreamWithContentType> GetThumbnailAsync();

    /// <summary>A read-only list of email addresses stored with the contact.</summary>
    /// <returns>A read-only list of email addresses.</returns>
    public extern IVectorView<ContactField> Emails { [MethodImpl] get; }

    /// <summary>A read-only list of phone numbers stored with the contact.</summary>
    /// <returns>A read-only list of phone numbers.</returns>
    public extern IVectorView<ContactField> PhoneNumbers { [MethodImpl] get; }

    /// <summary>A read-only list of locations stored with the contact.</summary>
    /// <returns>A read-only list of locations.</returns>
    public extern IVectorView<ContactLocationField> Locations { [MethodImpl] get; }

    /// <summary>A read-only list of instant messaging accounts stored with the contact.</summary>
    /// <returns>A read-only list of instant messaging accounts.</returns>
    public extern IVectorView<ContactInstantMessageField> InstantMessages { [MethodImpl] get; }

    /// <summary>A read-only list of the custom fields stored with the contact.</summary>
    /// <returns>A read-only list of custom fields.</returns>
    public extern IVectorView<ContactField> CustomFields { [MethodImpl] get; }

    /// <summary>Enables you to get the value for a custom field that is stored with a contact.</summary>
    /// <param name="customName">The name of the field.</param>
    /// <returns>The value of the field.</returns>
    [MethodImpl]
    public extern IVectorView<ContactField> QueryCustomFields(
      string customName);
  }
}
