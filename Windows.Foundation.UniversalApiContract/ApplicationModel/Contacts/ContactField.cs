// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Contacts.ContactField
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Contacts
{
  /// <summary>Describes a piece of contact data.</summary>
  [MarshalingBehavior(MarshalingType.Agile)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Activatable(typeof (IContactFieldFactory), 65536, "Windows.Foundation.UniversalApiContract")]
  public sealed class ContactField : IContactField
  {
    /// <summary>Creates a new ContactField object.</summary>
    /// <param name="value">The value that the field contains.</param>
    /// <param name="type">The type of contact data.</param>
    [MethodImpl]
    public extern ContactField(string value, ContactFieldType type);

    /// <summary>Creates a new ContactField object.</summary>
    /// <param name="value">The value for the contact field.</param>
    /// <param name="type">The type of contact data.</param>
    /// <param name="category">The category that the contact belongs to.</param>
    [MethodImpl]
    public extern ContactField(string value, ContactFieldType type, ContactFieldCategory category);

    /// <summary>Creates a new ContactField object.</summary>
    /// <param name="name">The name of the field.</param>
    /// <param name="value">The value the field contains.</param>
    /// <param name="type">The type of field.</param>
    /// <param name="category">The category the field belongs to.</param>
    [MethodImpl]
    public extern ContactField(
      string name,
      string value,
      ContactFieldType type,
      ContactFieldCategory category);

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
