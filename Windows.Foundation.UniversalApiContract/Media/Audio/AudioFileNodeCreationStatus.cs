// Decompiled with JetBrains decompiler
// Type: Windows.Media.Audio.AudioFileNodeCreationStatus
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Media.Audio
{
  /// <summary>Defines status values for audio file node creation.</summary>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public enum AudioFileNodeCreationStatus
  {
    /// <summary>Creation of the audio file node succeeded.</summary>
    Success,
    /// <summary>The audio file used to create the node was not found.</summary>
    FileNotFound,
    /// <summary>The audio file for node creation has an invalid file type.</summary>
    InvalidFileType,
    /// <summary>The format of the audio file is not supported.</summary>
    FormatNotSupported,
    /// <summary>An unknown failure occurred during creation of the audio file node.</summary>
    UnknownFailure,
  }
}
