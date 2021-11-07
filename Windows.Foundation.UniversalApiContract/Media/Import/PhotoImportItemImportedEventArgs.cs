// Decompiled with JetBrains decompiler
// Type: Windows.Media.Import.PhotoImportItemImportedEventArgs
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Media.Import
{
  /// <summary>Provides data for the PhotoImportFindItemsResult.ItemImported event.</summary>
  [MarshalingBehavior(MarshalingType.Agile)]
  [DualApiPartition(version = 167772160)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public sealed class PhotoImportItemImportedEventArgs : IPhotoImportItemImportedEventArgs
  {
    /// <summary>Gets the imported item associated with the PhotoImportFindItemsResult.ItemImported event.</summary>
    /// <returns>The imported item.</returns>
    public extern PhotoImportItem ImportedItem { [MethodImpl] get; }
  }
}
