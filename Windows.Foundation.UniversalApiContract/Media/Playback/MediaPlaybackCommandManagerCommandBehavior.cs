// Decompiled with JetBrains decompiler
// Type: Windows.Media.Playback.MediaPlaybackCommandManagerCommandBehavior
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Media.Playback
{
  /// <summary>For use with a MediaPlaybackCommandManager object, this class allows you to enable and disable System Media Transport Controls commands and allows you to respond to changes in the enabled state of a command.</summary>
  [DualApiPartition(version = 167772160)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  public sealed class MediaPlaybackCommandManagerCommandBehavior : 
    IMediaPlaybackCommandManagerCommandBehavior
  {
    /// <summary>Gets the MediaPlaybackCommandManager associated with the behavior.</summary>
    /// <returns>The command manager associated with the behavior.</returns>
    public extern MediaPlaybackCommandManager CommandManager { [MethodImpl] get; }

    /// <summary>Gets a value indicating whether a System Media Transport Controls command is currently enabled.</summary>
    /// <returns>True if the command is currently enabled; otherwise, false.</returns>
    public extern bool IsEnabled { [MethodImpl] get; }

    /// <summary>Gets or sets a value indicating whether a System Media Transport Controls command should always be enabled, should never be enabled, or if the system should automatically determine whether the command is enabled.</summary>
    /// <returns>A value defining the rule for enabling a System Media Transport Controls command.</returns>
    public extern MediaCommandEnablingRule EnablingRule { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Occurs when the enabled state of a System Media Transport Controls command changes.</summary>
    public extern event TypedEventHandler<MediaPlaybackCommandManagerCommandBehavior, object> IsEnabledChanged;
  }
}
