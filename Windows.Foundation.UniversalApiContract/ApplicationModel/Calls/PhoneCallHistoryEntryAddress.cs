// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Calls.PhoneCallHistoryEntryAddress
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Calls
{
  /// <summary>Address book information for a contact used by PhoneCallHistoryEntry objects.</summary>
  [Threading(ThreadingModel.Both)]
  [Activatable(typeof (IPhoneCallHistoryEntryAddressFactory), 65536, "Windows.Foundation.UniversalApiContract")]
  [Activatable(65536, "Windows.Foundation.UniversalApiContract")]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [MarshalingBehavior(MarshalingType.Agile)]
  public sealed class PhoneCallHistoryEntryAddress : IPhoneCallHistoryEntryAddress
  {
    /// <summary>Creates a new PhoneCallHistoryEntryAddress object with an initial address.</summary>
    /// <param name="rawAddress">The address to initiailize to the RawAddress property.</param>
    /// <param name="rawAddressKind">The type of address represented by *rawAddress*.</param>
    [MethodImpl]
    public extern PhoneCallHistoryEntryAddress(
      string rawAddress,
      PhoneCallHistoryEntryRawAddressKind rawAddressKind);

    /// <summary>Creates a new empty PhoneCallHistoryEntryAddress object.</summary>
    [MethodImpl]
    public extern PhoneCallHistoryEntryAddress();

    /// <summary>Gets or sets the unique identifier for this contact.</summary>
    /// <returns>The unique identifier for this address book entry.</returns>
    public extern string ContactId { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Get or sets the display name for this entry.</summary>
    /// <returns>The display name for this contact.</returns>
    public extern string DisplayName { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets the address information for this contact.</summary>
    /// <returns>The address information for this contact.</returns>
    public extern string RawAddress { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets the type of address indicated by RawAddress.</summary>
    /// <returns>The type of address.</returns>
    public extern PhoneCallHistoryEntryRawAddressKind RawAddressKind { [MethodImpl] get; [MethodImpl] set; }
  }
}
