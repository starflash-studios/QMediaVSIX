// Decompiled with JetBrains decompiler
// Type: Windows.Media.Import.PhotoImportProgress
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Media.Import
{
  /// <summary>The progress data for an asynchronous photo import operation.</summary>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public struct PhotoImportProgress
  {
    /// <summary>The number of items that have been imported.</summary>
    public uint ItemsImported;
    /// <summary>The total number of items to be imported.</summary>
    public uint TotalItemsToImport;
    /// <summary>The number of bytes that have been imported.</summary>
    public ulong BytesImported;
    /// <summary>The total number of bytes to be imported.</summary>
    public ulong TotalBytesToImport;
    /// <summary>The current import progress, expressed as a floating point value from 0 to 1.</summary>
    public double ImportProgress;
  }
}
