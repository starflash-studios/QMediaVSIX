// Decompiled with JetBrains decompiler
// Type: Windows.Media.Import.PhotoImportImportMode
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Media.Import
{
  /// <summary>Specifies the types of files that are included in an import operation.</summary>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public enum PhotoImportImportMode
  {
    /// <summary>All files are imported.</summary>
    ImportEverything,
    /// <summary>Sidecar files are ignored.</summary>
    IgnoreSidecars,
    /// <summary>Sibling files are ignored.</summary>
    IgnoreSiblings,
    /// <summary>Sidecar files and sibling files are ignored.</summary>
    IgnoreSidecarsAndSiblings,
  }
}
