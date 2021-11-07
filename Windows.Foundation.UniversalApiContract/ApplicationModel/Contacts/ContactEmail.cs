// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Contacts.ContactEmail
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Contacts
{
  /// <summary>Represents an email address of a contact.</summary>
  [Activatable(65536, "Windows.Foundation.UniversalApiContract")]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [MarshalingBehavior(MarshalingType.Agile)]
  public sealed class ContactEmail : IContactEmail
  {
    /// <summary>Initializes a new instance of a ContactEmail class.</summary>
    [MethodImpl]
    public extern ContactEmail();

    /// <summary>Gets and sets the email address of a contact. The maximum string length for the description is 321 characters.</summary>
    /// <returns>The email address of a contact.</returns>
    public extern string Address { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets and sets the kind of email address of a contact.</summary>
    /// <returns>A ContactEmailKind -typed value that indicates the type of email address.</returns>
    public extern ContactEmailKind Kind { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets and sets the description of an email address of a contact. The maximum string length for the description is 512 characters.</summary>
    /// <returns>The description of an email address of a contact.</returns>
    public extern string Description { [MethodImpl] get; [MethodImpl] set; }
  }
}
