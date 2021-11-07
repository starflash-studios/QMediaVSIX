// Decompiled with JetBrains decompiler
// Type: Windows.UI.ViewManagement.ApplicationViewConsolidatedEventArgs
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.ViewManagement
{
  /// <summary>Contains the results of a window (app view) consolidation operation.</summary>
  [MarshalingBehavior(MarshalingType.Agile)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public sealed class ApplicationViewConsolidatedEventArgs : 
    IApplicationViewConsolidatedEventArgs,
    IApplicationViewConsolidatedEventArgs2
  {
    /// <summary>Gets a value that indicates whether the window consolidation was user-initiated.</summary>
    /// <returns>**true** if the window consolidation operation was user-initiated; otherwise, **false**.</returns>
    public extern bool IsUserInitiated { [MethodImpl] get; }

    /// <summary>Gets a value that indicates whether the window consolidation was app-initiated.</summary>
    /// <returns>**true** if the window consolidation operation was app-initiated; otherwise **false**.</returns>
    public extern bool IsAppInitiated { [MethodImpl] get; }
  }
}
