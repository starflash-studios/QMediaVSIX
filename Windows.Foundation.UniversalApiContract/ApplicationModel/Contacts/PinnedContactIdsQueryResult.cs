// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Contacts.PinnedContactIdsQueryResult
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Contacts
{
  /// <summary>Provides access to the results of a query that lists the IDs all contacts pinned to the taskbar or Start menu.</summary>
  [MarshalingBehavior(MarshalingType.Agile)]
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  public sealed class PinnedContactIdsQueryResult : IPinnedContactIdsQueryResult
  {
    /// <summary>Gets the list of contact IDs that are pinned to the taskbar or **Start** menu.</summary>
    /// <returns>The list of contact IDs that are pinned to the taskbar or **Start** menu.</returns>
    public extern IVector<string> ContactIds { [MethodImpl] get; }
  }
}
