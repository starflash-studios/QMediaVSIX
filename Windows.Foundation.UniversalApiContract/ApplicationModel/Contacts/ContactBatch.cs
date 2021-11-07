// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Contacts.ContactBatch
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Contacts
{
  /// <summary>Represents a group of Contact objects and server search status.</summary>
  [Threading(ThreadingModel.Both)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [MarshalingBehavior(MarshalingType.Agile)]
  public sealed class ContactBatch : IContactBatch
  {
    /// <summary>Gets the list of Contact objects returned by a search operation.</summary>
    /// <returns>The list of contacts returned by a search operation.</returns>
    public extern IVectorView<Contact> Contacts { [MethodImpl] get; }

    /// <summary>Gets a ContactBatchStatus value that indicates if a search was successful or if there was a server error.</summary>
    /// <returns>A ContactBatchStatus value that indicates if a search was successful or if there was a server error.</returns>
    public extern ContactBatchStatus Status { [MethodImpl] get; }
  }
}
