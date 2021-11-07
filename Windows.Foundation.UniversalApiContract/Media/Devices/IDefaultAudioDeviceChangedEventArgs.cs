// Decompiled with JetBrains decompiler
// Type: Windows.Media.Devices.IDefaultAudioDeviceChangedEventArgs
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Media.Devices
{
  /// <summary>Called when the default audio device is changed for either audio render or capture.</summary>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(286230575, 7173, 18007, 161, 142, 71, 201, 182, 159, 7, 171)]
  public interface IDefaultAudioDeviceChangedEventArgs
  {
    /// <summary>Gets the ID of the newly selected audio device that raised the device change event.</summary>
    /// <returns>ID of the newly selected audio device that raised the device change event.</returns>
    string Id { get; }

    /// <summary>Gets the role of the newly selected audio device that raised the device change event.</summary>
    /// <returns>The role of the newly selected audio device that raised the device change event.</returns>
    AudioDeviceRole Role { get; }
  }
}
