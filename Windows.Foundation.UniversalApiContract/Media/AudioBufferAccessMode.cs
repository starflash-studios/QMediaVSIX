// Decompiled with JetBrains decompiler
// Type: Windows.Media.AudioBufferAccessMode
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Media
{
  /// <summary>Defines the access mode of an AudioBuffer returned by AudioFrame.LockBuffer.</summary>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public enum AudioBufferAccessMode
  {
    /// <summary>The audio buffer is read-only.</summary>
    Read,
    /// <summary>The audio buffer can be written to and read from.</summary>
    ReadWrite,
    /// <summary>The audio buffer is write-only.</summary>
    Write,
  }
}
