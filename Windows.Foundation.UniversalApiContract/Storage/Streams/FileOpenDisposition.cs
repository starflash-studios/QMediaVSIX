// Decompiled with JetBrains decompiler
// Type: Windows.Storage.Streams.FileOpenDisposition
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Storage.Streams
{
  /// <summary>Enumeration values for actions to take on a file.</summary>
  [ContractVersion(typeof (UniversalApiContract), 327680)]
  public enum FileOpenDisposition
  {
    /// <summary>Opens a file only if it exists.</summary>
    OpenExisting,
    /// <summary>Opens a file. If the file does not exist, a new file will be created and opened.</summary>
    OpenAlways,
    /// <summary>Creates a new file if one does not exist. If the file does exist, this will fail.</summary>
    CreateNew,
    /// <summary>Opens a file and truncates it so that its size is zero bytes. If the file does not exist, a new file will be created and opened.</summary>
    CreateAlways,
    /// <summary>Opens a file and truncates it so that its size is zero bytes. If the file does not exist, this will fail.</summary>
    TruncateExisting,
  }
}
