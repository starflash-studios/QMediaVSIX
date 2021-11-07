// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Contacts.PinnedContactManager
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
using Windows.System;

namespace Windows.ApplicationModel.Contacts
{
  /// <summary>Represents a service that source apps can call to pin and unpin contacts to and from the taskbar or **Start** menu.</summary>
  [MarshalingBehavior(MarshalingType.Agile)]
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  [Static(typeof (IPinnedContactManagerStatics), 262144, "Windows.Foundation.UniversalApiContract")]
  public sealed class PinnedContactManager : IPinnedContactManager
  {
    /// <summary>Gets the User associated with the PinnedContactManager.</summary>
    /// <returns>The User associated with the PinnedContactManager.</returns>
    public extern User User { [MethodImpl] get; }

    /// <summary>Indicates whether the specified location in the Windows UI supports contact pinning.</summary>
    /// <param name="surface">A pinnedContactSurface value that specifies a pinning location in the Windows UI. This property determines whether pinning is supported in that location.</param>
    /// <returns>A Boolean value that indicates whether the location in the Windows UI supports contact pinning.</returns>
    [MethodImpl]
    public extern bool IsPinSurfaceSupported(PinnedContactSurface surface);

    /// <summary>Indicates whether the specified contact is pinned to the specified location in the Windows user interface.</summary>
    /// <param name="contact">A contact of interest. This property indicates whether that contact is pinned or not pinned.</param>
    /// <param name="surface">A pinnedContactSurface value that specifies the location in the UI that you'd like to check for pinned contacts.</param>
    /// <returns>A Boolean value that specifies whether the specified contact is pinned to the specified location in the Windows user interface.</returns>
    [MethodImpl]
    public extern bool IsContactPinned(Contact contact, PinnedContactSurface surface);

    /// <summary>Pins a contact to the taskbar or **Start** menu.</summary>
    /// <param name="contact">The contact to pin to the taskbar or **Start** menu.</param>
    /// <param name="surface">A pinnedContactSurface value that specifies where in the Windows UI you would like to pin the contact.</param>
    /// <returns>An asynchronous operation that returns a Boolean value that indicates whether the contact was successfully pinned to the specified location.</returns>
    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperation<bool> RequestPinContactAsync(
      Contact contact,
      PinnedContactSurface surface);

    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperation<bool> RequestPinContactsAsync(
      IIterable<Contact> contacts,
      PinnedContactSurface surface);

    /// <summary>Unpins a contact from the taskbar or **Start** menu.</summary>
    /// <param name="contact">The contact to unpin from the taskbar or **Start** menu.</param>
    /// <param name="surface">A pinnedContactSurface value that specifies from which area in the Windows UI you would like to unpin the contact.</param>
    /// <returns>An asynchronous operation that returns a Boolean value that indicates whether the contact was successfully unpinned from the specified location.</returns>
    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperation<bool> RequestUnpinContactAsync(
      Contact contact,
      PinnedContactSurface surface);

    /// <summary>Indicates to Windows when activity that is related to a pinned contact occurs.</summary>
    /// <param name="contact">The contact that is exhibits activity.</param>
    [MethodImpl]
    public extern void SignalContactActivity(Contact contact);

    /// <summary>Gets the ID's of all contacts that are pinned to the taskbar or **Start** menu.</summary>
    /// <returns>An asynchronous operation that returns a PinnedContactIdsQueryResult that you can use to get the ID's of all pinned contacts.</returns>
    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperation<PinnedContactIdsQueryResult> GetPinnedContactIdsAsync();

    /// <summary>Gets the default an instance of a PinnedContactManager.</summary>
    /// <returns>the default PinnedContactManager.</returns>
    [MethodImpl]
    public static extern PinnedContactManager GetDefault();

    /// <summary>Gets a PinnedContactManager for the specified user.</summary>
    /// <param name="user">The user account to use to get the PinnedContactManager.</param>
    /// <returns>Returns the PinnedContactManager for the account specified by the *user* parameter.</returns>
    [MethodImpl]
    public static extern PinnedContactManager GetForUser(User user);

    /// <summary>Indicates whether the Windows UI supports contact pinning.</summary>
    /// <returns>A Boolean value that indicates whether the Windows UI supports contact pinning.</returns>
    [MethodImpl]
    public static extern bool IsSupported();
  }
}
