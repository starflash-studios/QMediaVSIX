// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Contacts.ContactFieldFactory
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Contacts
{
  /// <summary>&lt;!--Rearranged the description to streamline it and make it more similar to other class and interface descriptions.--&gt;</summary>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Activatable(65536, "Windows.Foundation.UniversalApiContract")]
  [MarshalingBehavior(MarshalingType.Agile)]
  public sealed class ContactFieldFactory : 
    IContactFieldFactory,
    IContactLocationFieldFactory,
    IContactInstantMessageFieldFactory
  {
    /// <summary>Creates an instance of the ContactFieldFactory class.</summary>
    [MethodImpl]
    public extern ContactFieldFactory();

    /// <summary>Creates a field to contain information about a contact.</summary>
    /// <param name="value">The value for the field.</param>
    /// <param name="type">The type of field.</param>
    /// <returns>Contains a field that you can add to a Contact object.</returns>
    [Overload("CreateField_Default")]
    [MethodImpl]
    public extern ContactField CreateField(string value, ContactFieldType type);

    /// <summary>Creates a field to contain information about a contact.</summary>
    /// <param name="value">The value for the field.</param>
    /// <param name="type">The type of field.</param>
    /// <param name="category">The category the field belongs to.</param>
    /// <returns>Contains a field that you can add to a Contact object.</returns>
    [Overload("CreateField_Category")]
    [MethodImpl]
    public extern ContactField CreateField(
      string value,
      ContactFieldType type,
      ContactFieldCategory category);

    /// <summary>Creates a field to contain information about a contact.</summary>
    /// <param name="name">The name of the field.</param>
    /// <param name="value">The value of the field.</param>
    /// <param name="type">The type of field.</param>
    /// <param name="category">The category the field belongs to.</param>
    /// <returns>Contains a field that you can add to a Contact object.</returns>
    [Overload("CreateField_Custom")]
    [MethodImpl]
    public extern ContactField CreateField(
      string name,
      string value,
      ContactFieldType type,
      ContactFieldCategory category);

    /// <summary>Creates a field to contain information about a contact's location.</summary>
    /// <param name="unstructuredAddress">The address of the contact in an unstructured format.</param>
    /// <returns>Contains a location field that you can add to a Contact object.</returns>
    [Overload("CreateLocation_Default")]
    [MethodImpl]
    public extern ContactLocationField CreateLocation(string unstructuredAddress);

    /// <summary>Creates a field to contain information about a contact's location.</summary>
    /// <param name="unstructuredAddress">The address of the contact in an unstructured format.</param>
    /// <param name="category">The category the field belongs to.</param>
    /// <returns>Contains a location field that you can add to a Contact object.</returns>
    [Overload("CreateLocation_Category")]
    [MethodImpl]
    public extern ContactLocationField CreateLocation(
      string unstructuredAddress,
      ContactFieldCategory category);

    /// <summary>Creates a field to contain information about a contact's location.</summary>
    /// <param name="unstructuredAddress">The address of the contact in an unstructured format.</param>
    /// <param name="category">The category the field belongs to.</param>
    /// <param name="street">The street address for the address.</param>
    /// <param name="city">The name of the city for the address.</param>
    /// <param name="region">The name of the region for the address.</param>
    /// <param name="country">The name of the country for the address.</param>
    /// <param name="postalCode">The postal code for the address.</param>
    /// <returns>Contains a location field that you can add to a Contact object.</returns>
    [Overload("CreateLocation_All")]
    [MethodImpl]
    public extern ContactLocationField CreateLocation(
      string unstructuredAddress,
      ContactFieldCategory category,
      string street,
      string city,
      string region,
      string country,
      string postalCode);

    /// <summary>Creates a field to contain information about a contact's instant messaging account.</summary>
    /// <param name="userName">The user name for the instant messaging account.</param>
    /// <returns>Contains an instant messaging field that you can add to a Contact object.</returns>
    [Overload("CreateInstantMessage_Default")]
    [MethodImpl]
    public extern ContactInstantMessageField CreateInstantMessage(
      string userName);

    /// <summary>Creates a field to contain information about a contact's instant messaging account.</summary>
    /// <param name="userName">The user name for the instant messaging account.</param>
    /// <param name="category">The category the field belongs to.</param>
    /// <returns>Contains an instant messaging field that you can add to a Contact object.</returns>
    [Overload("CreateInstantMessage_Category")]
    [MethodImpl]
    public extern ContactInstantMessageField CreateInstantMessage(
      string userName,
      ContactFieldCategory category);

    [Overload("CreateInstantMessage_All")]
    [MethodImpl]
    public extern ContactInstantMessageField CreateInstantMessage(
      string userName,
      ContactFieldCategory category,
      string service,
      string displayText,
      Uri verb);
  }
}
