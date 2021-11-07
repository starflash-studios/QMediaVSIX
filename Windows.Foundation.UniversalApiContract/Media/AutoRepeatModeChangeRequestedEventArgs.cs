// Decompiled with JetBrains decompiler
// Type: Windows.Media.AutoRepeatModeChangeRequestedEventArgs
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Media
{
  /// <summary>Provides data for the AutoRepeatModeChangeRequested event.</summary>
  [Muse(Version = 167772160)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public sealed class AutoRepeatModeChangeRequestedEventArgs : 
    IAutoRepeatModeChangeRequestedEventArgs
  {
    /// <summary>Gets a value indicating the requested auto-repeat mode.</summary>
    /// <returns>The requested auto-repeat mode.</returns>
    public extern MediaPlaybackAutoRepeatMode RequestedAutoRepeatMode { [MethodImpl] get; }
  }
}
