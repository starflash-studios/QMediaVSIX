// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Contacts.ContactPhone
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Contacts
{
  /// <summary>Represents information about the phone for a contact.</summary>
  [MarshalingBehavior(MarshalingType.Agile)]
  [Activatable(65536, "Windows.Foundation.UniversalApiContract")]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Muse(Version = 100859904)]
  public sealed class ContactPhone : IContactPhone
  {
    /// <summary>Initializes a new instance of a ContactPhone class.</summary>
    [MethodImpl]
    public extern ContactPhone();

    /// <summary>Gets and sets the phone number of a phone for a contact. The maximum string length for the phone number is 50 characters.</summary>
    /// <returns>The phone number of a phone for a contact.</returns>
    public extern string Number { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets and sets the kind of phone for a contact.</summary>
    /// <returns>A ContactPhoneKind -typed value that indicates the kind of phone.</returns>
    public extern ContactPhoneKind Kind { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets and sets the description of the phone for a contact. The maximum string length for the description is 512 characters.</summary>
    /// <returns>The description of the phone for a contact.</returns>
    public extern string Description { [MethodImpl] get; [MethodImpl] set; }
  }
}
