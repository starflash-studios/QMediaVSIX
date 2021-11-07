// Decompiled with JetBrains decompiler
// Type: Windows.Storage.Search.FolderDepth
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Storage.Search
{
  /// <summary>Indicates whether all files and subfolders of the folder being queried will be enumerated or if only the top-level files and subfolders will be enumerated.</summary>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public enum FolderDepth
  {
    /// <summary>Perform a shallow enumeration of the folder being queried. Only the top-level, child files and folders of the folder being queried will be returned. This is similar to the view that Windows Explorer would provide for the folder being queried.</summary>
    Shallow,
    /// <summary>Perform a deep enumeration of the folder contents. Windows traverses through subfolders to discover content and presents the results in a single list that combines all discovered content.</summary>
    Deep,
  }
}
