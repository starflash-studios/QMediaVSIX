// Decompiled with JetBrains decompiler
// Type: Windows.Media.MediaProperties.MediaMirroringOptions
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Media.MediaProperties
{
  /// <summary>Defines the direction in of a mirror transform.</summary>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Flags]
  public enum MediaMirroringOptions : uint
  {
    /// <summary>No mirroring.</summary>
    None = 0,
    /// <summary>Mirror horizontally.</summary>
    Horizontal = 1,
    /// <summary>Mirror vertically.</summary>
    Vertical = 2,
  }
}
