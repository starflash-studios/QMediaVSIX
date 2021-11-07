// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Contacts.ContactSignificantOther
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Contacts
{
  /// <summary>Represents the info about a significant other for a contact.</summary>
  [MarshalingBehavior(MarshalingType.Agile)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Activatable(65536, "Windows.Foundation.UniversalApiContract")]
  public sealed class ContactSignificantOther : IContactSignificantOther, IContactSignificantOther2
  {
    /// <summary>Initializes a new instance of a ContactSignificantOther class.</summary>
    [MethodImpl]
    public extern ContactSignificantOther();

    /// <summary>Gets and sets the name of a significant other for a contact. The maximum string length for the name is 256 characters.</summary>
    /// <returns>The name of a significant other for a contact.</returns>
    public extern string Name { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets and sets the description of a significant other for a contact. The maximum string length for the description is 512 characters.</summary>
    /// <returns>The description of a significant other for a contact.</returns>
    public extern string Description { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or puts a value that indicates the nature of the relationship, such as spouse, partner, sibling, parent and so on.</summary>
    /// <returns>A value that indicates the nature of the relationship, such as spouse, partner, sibling, parent and so on.</returns>
    public extern ContactRelationship Relationship { [MethodImpl] get; [MethodImpl] set; }
  }
}
