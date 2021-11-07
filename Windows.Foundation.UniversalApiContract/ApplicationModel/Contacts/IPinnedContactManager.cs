// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Contacts.IPinnedContactManager
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
using Windows.System;

namespace Windows.ApplicationModel.Contacts
{
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  [ExclusiveTo(typeof (PinnedContactManager))]
  [Guid(4240208908, 57814, 17859, 184, 182, 163, 86, 4, 225, 103, 160)]
  internal interface IPinnedContactManager
  {
    User User { get; }

    bool IsPinSurfaceSupported(PinnedContactSurface surface);

    bool IsContactPinned(Contact contact, PinnedContactSurface surface);

    [RemoteAsync]
    IAsyncOperation<bool> RequestPinContactAsync(
      Contact contact,
      PinnedContactSurface surface);

    [RemoteAsync]
    IAsyncOperation<bool> RequestPinContactsAsync(
      IIterable<Contact> contacts,
      PinnedContactSurface surface);

    [RemoteAsync]
    IAsyncOperation<bool> RequestUnpinContactAsync(
      Contact contact,
      PinnedContactSurface surface);

    void SignalContactActivity(Contact contact);

    [RemoteAsync]
    IAsyncOperation<PinnedContactIdsQueryResult> GetPinnedContactIdsAsync();
  }
}
