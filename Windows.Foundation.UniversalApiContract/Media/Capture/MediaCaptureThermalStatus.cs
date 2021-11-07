// Decompiled with JetBrains decompiler
// Type: Windows.Media.Capture.MediaCaptureThermalStatus
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Media.Capture
{
  /// <summary>Specifies the thermal status of a media capture device.</summary>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public enum MediaCaptureThermalStatus
  {
    /// <summary>The thermal state is normal.</summary>
    Normal,
    /// <summary>The capture device is overheated. You should stop the current capture session and save any captured media.</summary>
    Overheated,
  }
}
