// Decompiled with JetBrains decompiler
// Type: Windows.Media.PlayTo.MuteChangeRequestedEventArgs
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Media.PlayTo
{
  /// <summary>Provides information about the MuteChangeRequested event.</summary>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public sealed class MuteChangeRequestedEventArgs : IMuteChangeRequestedEventArgs
  {
    /// <summary>Gets a value that indicates whether mute or unmute was requested.</summary>
    /// <returns>True if mute was requested; otherwise false.</returns>
    public extern bool Mute { [MethodImpl] get; }
  }
}
