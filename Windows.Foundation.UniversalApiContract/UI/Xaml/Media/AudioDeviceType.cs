// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Media.AudioDeviceType
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Media
{
  /// <summary>Describes the primary usage of the device that is being used to play back audio. This value is used by AudioDeviceType.</summary>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [WebHostHidden]
  public enum AudioDeviceType
  {
    /// <summary>The device is a console and the audio session might support games, notifications, voice commands, and so on.</summary>
    Console,
    /// <summary>The device is intended for multimedia playback and/or recording.</summary>
    Multimedia,
    /// <summary>The device is primarily for voice communications.</summary>
    Communications,
  }
}
