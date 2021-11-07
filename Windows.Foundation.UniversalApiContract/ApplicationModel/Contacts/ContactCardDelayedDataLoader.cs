// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Contacts.ContactCardDelayedDataLoader
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Contacts
{
  /// <summary>Represents a delayed data loader for a contact card.</summary>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [MarshalingBehavior(MarshalingType.Agile)]
  public sealed class ContactCardDelayedDataLoader : IContactCardDelayedDataLoader, IClosable
  {
    /// <summary>Updates the contact card with the Contact object and completes the contact card UI.</summary>
    /// <param name="contact">The contact to update the contact card with.</param>
    [MethodImpl]
    public extern void SetData(Contact contact);

    [MethodImpl]
    public extern void Close();
  }
}
