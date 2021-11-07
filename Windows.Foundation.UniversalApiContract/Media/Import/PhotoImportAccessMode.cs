// Decompiled with JetBrains decompiler
// Type: Windows.Media.Import.PhotoImportAccessMode
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Media.Import
{
  /// <summary>Specifies the access mode with which photos are imported.</summary>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public enum PhotoImportAccessMode
  {
    /// <summary>Photos are imported with read and write access.</summary>
    ReadWrite,
    /// <summary>Photos are imported with read-only access.</summary>
    ReadOnly,
    /// <summary>Photos are imported with read and delete access.</summary>
    ReadAndDelete,
  }
}
