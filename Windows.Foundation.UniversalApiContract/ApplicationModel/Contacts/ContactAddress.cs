// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Contacts.ContactAddress
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Contacts
{
  /// <summary>Represents the address of a contact.</summary>
  [Activatable(65536, "Windows.Foundation.UniversalApiContract")]
  [MarshalingBehavior(MarshalingType.Agile)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public sealed class ContactAddress : IContactAddress
  {
    /// <summary>Initializes a new instance of a ContactAddress class.</summary>
    [MethodImpl]
    public extern ContactAddress();

    /// <summary>Gets and sets the street address of a contact address. The maximum string length for the street address is 1024 characters.</summary>
    /// <returns>The street address of a contact address.</returns>
    public extern string StreetAddress { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets and sets the locality of a contact address. The maximum string length for the locality is 1024 characters.</summary>
    /// <returns>The locality of a contact address.</returns>
    public extern string Locality { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets and sets the region of a contact address. The maximum string length for the region is 1024 characters.</summary>
    /// <returns>The region of a contact address.</returns>
    public extern string Region { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets and sets the country of a contact address. The maximum string length for the country is 1024 characters.</summary>
    /// <returns>The country of a contact address.</returns>
    public extern string Country { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets and sets the postal code of a contact address. The maximum string length for the postal code is 1024 characters.</summary>
    /// <returns>The postal code of a contact address.</returns>
    public extern string PostalCode { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets and sets the kind of contact address.</summary>
    /// <returns>A ContactAddressKind -typed value that indicates the type of contact address.</returns>
    public extern ContactAddressKind Kind { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets and sets the description of a contact address. The maximum string length for the description is 512 characters.</summary>
    /// <returns>The description of a contact address.</returns>
    public extern string Description { [MethodImpl] get; [MethodImpl] set; }
  }
}
