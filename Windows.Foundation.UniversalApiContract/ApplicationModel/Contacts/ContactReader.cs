// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Contacts.ContactReader
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Contacts
{
  /// <summary>Used to read Contact objects in batches from the ContactStore which may be local or remotely located.</summary>
  [MarshalingBehavior(MarshalingType.Agile)]
  [Threading(ThreadingModel.Both)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public sealed class ContactReader : IContactReader
  {
    /// <summary>Asynchronously reads a batch of Contact objects from the ContactStore.</summary>
    /// <returns>The batch of contacts read from the ContactStore.</returns>
    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperation<ContactBatch> ReadBatchAsync();

    /// <summary>Gets the reason a Contact matched the search query. Returns the properties and substrings that match.</summary>
    /// <param name="contact">The Contact for which to get the matching properties.</param>
    /// <returns>The list of matching properties and match reasons.</returns>
    [MethodImpl]
    public extern IVectorView<ContactMatchReason> GetMatchingPropertiesWithMatchReason(
      Contact contact);
  }
}
