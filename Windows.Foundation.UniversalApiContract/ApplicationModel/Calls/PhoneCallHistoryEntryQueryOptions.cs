// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Calls.PhoneCallHistoryEntryQueryOptions
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Calls
{
  /// <summary>Options for querying the phone call entries.</summary>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [Threading(ThreadingModel.Both)]
  [Activatable(65536, "Windows.Foundation.UniversalApiContract")]
  public sealed class PhoneCallHistoryEntryQueryOptions : IPhoneCallHistoryEntryQueryOptions
  {
    /// <summary>Creates a new PhoneCallHistoryEntryQueryOptions object.</summary>
    [MethodImpl]
    public extern PhoneCallHistoryEntryQueryOptions();

    /// <summary>Gets or sets the query filter based on the type of media.</summary>
    /// <returns>The type of media that is included in the filter.</returns>
    public extern PhoneCallHistoryEntryQueryDesiredMedia DesiredMedia { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Get the query filter based on the source ID of the phone call entry.</summary>
    /// <returns>The list of PhoneCallHistoryEntry.SourceId that are part of the filter.</returns>
    public extern IVector<string> SourceIds { [MethodImpl] get; }
  }
}
