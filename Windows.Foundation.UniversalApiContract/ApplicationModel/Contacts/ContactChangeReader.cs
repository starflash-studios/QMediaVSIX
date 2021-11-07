// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Contacts.ContactChangeReader
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Contacts
{
  /// <summary>Provides a way to monitor and react to changes to contacts.</summary>
  [MarshalingBehavior(MarshalingType.Agile)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Threading(ThreadingModel.Both)]
  public sealed class ContactChangeReader : IContactChangeReader
  {
    /// <summary>Call this method to indicate that you have processed and accepted all changes and you don't want the system to show them to you again.</summary>
    [MethodImpl]
    public extern void AcceptChanges();

    /// <summary>Call this method to indicate that you have processed and accepted up through the specified change.</summary>
    /// <param name="lastChangeToAccept">The last change that you want to system to track as accepted by your app.</param>
    [MethodImpl]
    public extern void AcceptChangesThrough(ContactChange lastChangeToAccept);

    /// <summary>Asynchronously gets a list of ContactChange objects.</summary>
    /// <returns>A list of ContactChange objects.</returns>
    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperation<IVectorView<ContactChange>> ReadBatchAsync();
  }
}
