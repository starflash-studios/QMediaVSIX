// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Contacts.ContactConnectedServiceAccount
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Contacts
{
  /// <summary>Represents a connected service account for a contact.</summary>
  [MarshalingBehavior(MarshalingType.Agile)]
  [Activatable(65536, "Windows.Foundation.UniversalApiContract")]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public sealed class ContactConnectedServiceAccount : IContactConnectedServiceAccount
  {
    /// <summary>Initializes a new instance of a ContactConnectedServiceAccount class.</summary>
    [MethodImpl]
    public extern ContactConnectedServiceAccount();

    /// <summary>Gets and sets the identifier of a connected service account for a contact. The maximum string length for the identifier is 321 characters.</summary>
    /// <returns>The identifier of a connected service account for a contact.</returns>
    public extern string Id { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets and sets the service name of a connected service account for a contact. The maximum string length for the service name is 256 characters.</summary>
    /// <returns>The service name of a connected service account for a contact.</returns>
    public extern string ServiceName { [MethodImpl] get; [MethodImpl] set; }
  }
}
