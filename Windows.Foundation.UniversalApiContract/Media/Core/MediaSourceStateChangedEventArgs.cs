// Decompiled with JetBrains decompiler
// Type: Windows.Media.Core.MediaSourceStateChangedEventArgs
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Media.Core
{
  /// <summary>Provides data for the StateChanged event of a MediaSource object.</summary>
  [MarshalingBehavior(MarshalingType.Agile)]
  [ContractVersion(typeof (UniversalApiContract), 131072)]
  [DualApiPartition(version = 167772160)]
  [Threading(ThreadingModel.Both)]
  public sealed class MediaSourceStateChangedEventArgs : IMediaSourceStateChangedEventArgs
  {
    /// <summary>Gets the previous state of the MediaSource before the state changed.</summary>
    /// <returns>The previous state of the MediaSource before the state changed.</returns>
    public extern MediaSourceState OldState { [MethodImpl] get; }

    /// <summary>Gets the new current state of the MediaSource.</summary>
    /// <returns>The new current state of the MediaSource.</returns>
    public extern MediaSourceState NewState { [MethodImpl] get; }
  }
}
