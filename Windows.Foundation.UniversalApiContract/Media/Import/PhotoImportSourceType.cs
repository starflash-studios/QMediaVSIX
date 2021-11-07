// Decompiled with JetBrains decompiler
// Type: Windows.Media.Import.PhotoImportSourceType
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Media.Import
{
  /// <summary>Specifies the type of device that is being used as a photo import source.</summary>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public enum PhotoImportSourceType
  {
    /// <summary>The device is a generic photo import source.</summary>
    Generic,
    /// <summary>The device is a camera.</summary>
    Camera,
    /// <summary>The device is a media player.</summary>
    MediaPlayer,
    /// <summary>The device is a phone.</summary>
    Phone,
    /// <summary>The device is a video camera.</summary>
    Video,
    /// <summary>The device is a personal information manager.</summary>
    PersonalInfoManager,
    /// <summary>The device is an audio recorder.</summary>
    AudioRecorder,
  }
}
