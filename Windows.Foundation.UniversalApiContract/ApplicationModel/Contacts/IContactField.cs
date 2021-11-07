// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Contacts.IContactField
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Contacts
{
  /// <summary>Specifies an object that describes a piece of contact data.</summary>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(2977319018, 53907, 18732, 160, 88, 219, 87, 91, 62, 60, 15)]
  public interface IContactField
  {
    /// <summary>Gets the contact field type for the data.</summary>
    /// <returns>The type of data.</returns>
    ContactFieldType Type { get; }

    /// <summary>Gets the category for the contact data.</summary>
    /// <returns>The category for the contact data.</returns>
    ContactFieldCategory Category { get; }

    /// <summary>Gets the name of the field.</summary>
    /// <returns>The name of the field.</returns>
    string Name { get; }

    /// <summary>Gets the value of the contact data.</summary>
    /// <returns>The value of the contact data.</returns>
    string Value { get; }
  }
}
