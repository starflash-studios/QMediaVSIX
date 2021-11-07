// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Contacts.ContactWebsite
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Contacts
{
  /// <summary>Represents the info about a Web site for a contact.</summary>
  [Activatable(65536, "Windows.Foundation.UniversalApiContract")]
  [MarshalingBehavior(MarshalingType.Agile)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public sealed class ContactWebsite : IContactWebsite, IContactWebsite2
  {
    /// <summary>Initializes a new instance of a ContactWebsite class.</summary>
    [MethodImpl]
    public extern ContactWebsite();

    /// <summary>Gets and sets the Uniform Resource Identifier (URI) of a Web site for a contact.</summary>
    /// <returns>The Uniform Resource Identifier (URI) of a Web site for a contact.</returns>
    public extern Uri Uri { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets and sets the description of a Web site for a contact. The maximum string length for the description is 512 characters.</summary>
    /// <returns>The description of a Web site for a contact.</returns>
    public extern string Description { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets the raw website address for the contact. This address is not checked for valid URI formatting.</summary>
    /// <returns>The raw website address for the contact.</returns>
    public extern string RawValue { [MethodImpl] get; [MethodImpl] set; }
  }
}
