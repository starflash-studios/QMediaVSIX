// Decompiled with JetBrains decompiler
// Type: Windows.Storage.Pickers.Provider.FileSelectionMode
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Storage.Pickers.Provider
{
  /// <summary>Indicates whether the file picker currently limits selection to single files, or if multiple files can be selected.</summary>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public enum FileSelectionMode
  {
    /// <summary>Only a single file can be selected.</summary>
    Single,
    /// <summary>Multiple files can be selected.</summary>
    Multiple,
  }
}
