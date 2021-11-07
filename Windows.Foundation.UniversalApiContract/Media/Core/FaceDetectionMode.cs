// Decompiled with JetBrains decompiler
// Type: Windows.Media.Core.FaceDetectionMode
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Media.Core
{
  /// <summary>Specifies the mode used for face detection.</summary>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public enum FaceDetectionMode
  {
    /// <summary>The speed of face detection is prioritized over the accuracy of the face detection results.</summary>
    HighPerformance,
    /// <summary>The prioritization of detection speed and result quality are balanced.</summary>
    Balanced,
    /// <summary>The accuracy of face detection results is prioritized over the speed of face detection.</summary>
    HighQuality,
  }
}
