// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Contacts.ContactLocationField
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Contacts
{
  /// <summary>Contains information about a user's location and address.</summary>
  [Activatable(typeof (IContactLocationFieldFactory), 65536, "Windows.Foundation.UniversalApiContract")]
  [MarshalingBehavior(MarshalingType.Agile)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public sealed class ContactLocationField : IContactLocationField, IContactField
  {
    /// <summary>Creates a new ContactLocationField object.</summary>
    /// <param name="unstructuredAddress">The address of the contact in an unstructured format.</param>
    [MethodImpl]
    public extern ContactLocationField(string unstructuredAddress);

    /// <summary>Creates a new ContactLocationField object.</summary>
    /// <param name="unstructuredAddress">The address of the contact in an unstructured format.</param>
    /// <param name="category">The category the field belongs to.</param>
    [MethodImpl]
    public extern ContactLocationField(string unstructuredAddress, ContactFieldCategory category);

    /// <summary>Creates a new ContactLocationField object.</summary>
    /// <param name="unstructuredAddress">The address of the contact in an unstructured format.</param>
    /// <param name="category">The category for the contact data.</param>
    /// <param name="street">The street address of the contact.</param>
    /// <param name="city">The name of the city for this contact's address.</param>
    /// <param name="region">The name of the region for this contact's address.</param>
    /// <param name="country">The name of the country for this contact's address.</param>
    /// <param name="postalCode">The postal code for this contact's address.</param>
    [MethodImpl]
    public extern ContactLocationField(
      string unstructuredAddress,
      ContactFieldCategory category,
      string street,
      string city,
      string region,
      string country,
      string postalCode);

    /// <summary>Gets a string that represents an unstructured address.</summary>
    /// <returns>The address of the contact in an unstructured format.</returns>
    public extern string UnstructuredAddress { [MethodImpl] get; }

    /// <summary>Gets the contact's street.</summary>
    /// <returns>The contact's street.</returns>
    public extern string Street { [MethodImpl] get; }

    /// <summary>Gets the contact's city.</summary>
    /// <returns>The contact's city.</returns>
    public extern string City { [MethodImpl] get; }

    /// <summary>Gets the contact's region.</summary>
    /// <returns>The contact's region.</returns>
    public extern string Region { [MethodImpl] get; }

    /// <summary>Gets the contact's country.</summary>
    /// <returns>The contact's country.</returns>
    public extern string Country { [MethodImpl] get; }

    /// <summary>Gets the contact's postal code.</summary>
    /// <returns>The contact's postal code.</returns>
    public extern string PostalCode { [MethodImpl] get; }

    /// <summary>Gets the contact field type for the data.</summary>
    /// <returns>The type of data.</returns>
    public extern ContactFieldType Type { [MethodImpl] get; }

    /// <summary>Gets the category for the contact data.</summary>
    /// <returns>The category for the contact data.</returns>
    public extern ContactFieldCategory Category { [MethodImpl] get; }

    /// <summary>Gets the name of the field.</summary>
    /// <returns>The name of the field.</returns>
    public extern string Name { [MethodImpl] get; }

    /// <summary>Gets the value of the contact data.</summary>
    /// <returns>The value of the contact data.</returns>
    public extern string Value { [MethodImpl] get; }
  }
}
