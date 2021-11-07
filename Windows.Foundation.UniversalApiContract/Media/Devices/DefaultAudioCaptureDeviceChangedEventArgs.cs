// Decompiled with JetBrains decompiler
// Type: Windows.Media.Devices.DefaultAudioCaptureDeviceChangedEventArgs
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Media.Devices
{
  /// <summary>Contains information about a default audio capture device change event.</summary>
  [MarshalingBehavior(MarshalingType.Agile)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public sealed class DefaultAudioCaptureDeviceChangedEventArgs : IDefaultAudioDeviceChangedEventArgs
  {
    /// <summary>Gets the ID of the newly selected audio capture device that caused the change event.</summary>
    /// <returns>ID of the newly selected audio capture device that caused the change event.</returns>
    public extern string Id { [MethodImpl] get; }

    /// <summary>Gets the role of the newly selected audio capture device that caused the change event.</summary>
    /// <returns>The role of the newly selected audio capture device that caused the change event.</returns>
    public extern AudioDeviceRole Role { [MethodImpl] get; }
  }
}
