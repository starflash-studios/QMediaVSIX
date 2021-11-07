// Decompiled with JetBrains decompiler
// Type: Windows.Media.Import.PhotoImportSubfolderCreationMode
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Media.Import
{
  /// <summary>Specifies the method used for naming subfolders within the destination folder.</summary>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public enum PhotoImportSubfolderCreationMode
  {
    /// <summary>No subfolders are created.</summary>
    DoNotCreateSubfolders,
    /// <summary>Subfolders are created based on the file date of the imported files.</summary>
    CreateSubfoldersFromFileDate,
    /// <summary>Subfolders are created based on the EXIF date of the imported files.</summary>
    CreateSubfoldersFromExifDate,
    /// <summary>Subfolders are created to match the folder structure of the import source.</summary>
    KeepOriginalFolderStructure,
  }
}
