// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Contacts.IContactFieldFactory
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Contacts
{
  /// <summary>&lt;!--Changed beginning of sentence to make description more streamlined.--&gt;</summary>
  [Guid(2246218047, 3658, 19006, 137, 148, 64, 106, 231, 237, 100, 110)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public interface IContactFieldFactory
  {
    /// <summary>Creates a field to contain information about a contact.</summary>
    /// <param name="value">The value for the field.</param>
    /// <param name="type">The type of field.</param>
    /// <returns>A field that you can add to a Contact object.</returns>
    [Overload("CreateField_Default")]
    ContactField CreateField(string value, ContactFieldType type);

    /// <summary>Creates a field to contain information about a contact.</summary>
    /// <param name="value">The value of the field.</param>
    /// <param name="type">The type of field.</param>
    /// <param name="category">The category the field belongs to.</param>
    /// <returns>A field that you can add to a Contact object.</returns>
    [Overload("CreateField_Category")]
    ContactField CreateField(
      string value,
      ContactFieldType type,
      ContactFieldCategory category);

    /// <summary>Creates a field to contain information about a contact.</summary>
    /// <param name="name">The name of the field.</param>
    /// <param name="value">The value the field contains.</param>
    /// <param name="type">The type of field.</param>
    /// <param name="category">The category the field belongs to.</param>
    /// <returns>A field that you can add to a Contact object.</returns>
    [Overload("CreateField_Custom")]
    ContactField CreateField(
      string name,
      string value,
      ContactFieldType type,
      ContactFieldCategory category);
  }
}
