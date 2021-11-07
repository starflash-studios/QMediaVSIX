// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Contacts.IContactLocationFieldFactory
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Contacts
{
  /// <summary>&lt;!--Changed beginning of sentence to make description more streamlined.--&gt;</summary>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(4154012375, 12255, 17406, 143, 24, 65, 137, 115, 144, 188, 254)]
  public interface IContactLocationFieldFactory
  {
    /// <summary>Creates a field to contain information about a contact's location.</summary>
    /// <param name="unstructuredAddress">The address of the contact in an unstructured format.</param>
    /// <returns>A location field that you can add to a Contact object.</returns>
    [Overload("CreateLocation_Default")]
    ContactLocationField CreateLocation(string unstructuredAddress);

    /// <summary>Creates a field to contain information about a contact's location.</summary>
    /// <param name="unstructuredAddress">The address of the contact in an unstructured format.</param>
    /// <param name="category">The category the field belongs to.</param>
    /// <returns>A location field that you can add to a Contact object.</returns>
    [Overload("CreateLocation_Category")]
    ContactLocationField CreateLocation(
      string unstructuredAddress,
      ContactFieldCategory category);

    /// <summary>Creates a field to contain information about a contact's location.</summary>
    /// <param name="unstructuredAddress">The address of the contact in an unstructured format.</param>
    /// <param name="category">The category the field belongs to.</param>
    /// <param name="street">The street address.</param>
    /// <param name="city">The name of the city for the address.</param>
    /// <param name="region">The name of the region for the address.</param>
    /// <param name="country">The name of the country for the address.</param>
    /// <param name="postalCode">The postal code for the address.</param>
    /// <returns>A location field that you can add to a Contact object.</returns>
    [Overload("CreateLocation_All")]
    ContactLocationField CreateLocation(
      string unstructuredAddress,
      ContactFieldCategory category,
      string street,
      string city,
      string region,
      string country,
      string postalCode);
  }
}
