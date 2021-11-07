// Decompiled with JetBrains decompiler
// Type: Windows.Media.Import.PhotoImportItemSelectionMode
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Media.Import
{
  /// <summary>Specifies the initial selection state for items that are discovered using PhotoImportSession.FindItemsAsync.</summary>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public enum PhotoImportItemSelectionMode
  {
    /// <summary>All found items are initially selected.</summary>
    SelectAll,
    /// <summary>No found items are initially selected.</summary>
    SelectNone,
    /// <summary>New found items are initially selected.</summary>
    SelectNew,
  }
}
