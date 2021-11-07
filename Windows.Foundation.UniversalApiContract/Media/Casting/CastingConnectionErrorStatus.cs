// Decompiled with JetBrains decompiler
// Type: Windows.Media.Casting.CastingConnectionErrorStatus
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Media.Casting
{
  /// <summary>Indicates the error status when starting or ending a casting connection.</summary>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public enum CastingConnectionErrorStatus
  {
    /// <summary>Starting or ending the connection was successful.</summary>
    Succeeded,
    /// <summary>The device did not respond to the attempt to start or end theconnection.</summary>
    DeviceDidNotRespond,
    /// <summary>The device returned an error when attempting to start or end the connection.</summary>
    DeviceError,
    /// <summary>The device was locked and a start or end the connection could not be made.</summary>
    DeviceLocked,
    /// <summary>The device could not provide protected playback.</summary>
    ProtectedPlaybackFailed,
    /// <summary>The casting source was invalid.</summary>
    InvalidCastingSource,
    /// <summary>An unknown error occurred when attempting to start or end the connection.</summary>
    Unknown,
  }
}
