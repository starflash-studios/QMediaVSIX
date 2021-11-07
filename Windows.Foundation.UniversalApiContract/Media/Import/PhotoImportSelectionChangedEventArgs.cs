// Decompiled with JetBrains decompiler
// Type: Windows.Media.Import.PhotoImportSelectionChangedEventArgs
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Media.Import
{
  /// <summary>Provides data for the PhotoImportFindItemsResult.SelectionChanged event.</summary>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [DualApiPartition(version = 167772160)]
  [MarshalingBehavior(MarshalingType.Agile)]
  public sealed class PhotoImportSelectionChangedEventArgs : IPhotoImportSelectionChangedEventArgs
  {
    /// <summary>Gets a value indicating whether no items are selected after the selection has changed.</summary>
    /// <returns>True if no items are selected; otherwise, false.</returns>
    public extern bool IsSelectionEmpty { [MethodImpl] get; }
  }
}
