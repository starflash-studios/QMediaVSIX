// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Contacts.ContactDate
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Contacts
{
  /// <summary>Represents an important date for a contact.</summary>
  [Activatable(65536, "Windows.Foundation.UniversalApiContract")]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [MarshalingBehavior(MarshalingType.Agile)]
  public sealed class ContactDate : IContactDate
  {
    /// <summary>Initializes a new instance of a ContactDate class.</summary>
    [MethodImpl]
    public extern ContactDate();

    /// <summary>Gets and sets the day for an important date for a contact.</summary>
    /// <returns>The day for an important date for a contact.</returns>
    public extern IReference<uint> Day { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets and sets the month for an important date for a contact.</summary>
    /// <returns>The month for an important date for a contact.</returns>
    public extern IReference<uint> Month { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets and sets the year for an important date for a contact. This value must be convertible to a FILETIME structure.</summary>
    /// <returns>The year for an important date for a contact.</returns>
    public extern IReference<int> Year { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets and sets the kind of important date for a contact.</summary>
    /// <returns>A ContactDateKind -typed value that indicates the type of important date for a contact.</returns>
    public extern ContactDateKind Kind { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets and sets the description for an important date for a contact. The maximum string length for the description is 512 characters.</summary>
    /// <returns>The description for an important date for a contact.</returns>
    public extern string Description { [MethodImpl] get; [MethodImpl] set; }
  }
}
