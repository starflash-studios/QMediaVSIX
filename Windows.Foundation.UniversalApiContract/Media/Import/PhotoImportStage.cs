// Decompiled with JetBrains decompiler
// Type: Windows.Media.Import.PhotoImportStage
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Media.Import
{
  /// <summary>Specifies the stages of the photo import process.</summary>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public enum PhotoImportStage
  {
    /// <summary>The photo import process has not started.</summary>
    NotStarted,
    /// <summary>Items are currently being found.</summary>
    FindingItems,
    /// <summary>Items are currently being imported</summary>
    ImportingItems,
    /// <summary>Imported items are currently being deleted from the source.</summary>
    DeletingImportedItemsFromSource,
  }
}
