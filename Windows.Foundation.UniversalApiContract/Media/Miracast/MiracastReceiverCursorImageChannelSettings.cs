// Decompiled with JetBrains decompiler
// Type: Windows.Media.Miracast.MiracastReceiverCursorImageChannelSettings
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Graphics;

namespace Windows.Media.Miracast
{
  /// <summary>An object that represents settings that can be configured on the MiracastReceiverCursorImageChannel.</summary>
  [DualApiPartition(version = 1)]
  [ContractVersion(typeof (UniversalApiContract), 524288)]
  [MarshalingBehavior(MarshalingType.Agile)]
  public sealed class MiracastReceiverCursorImageChannelSettings : 
    IMiracastReceiverCursorImageChannelSettings
  {
    /// <summary>Gets or sets the enabled status of the use of the separate channel for mouse cursor images.</summary>
    /// <returns>True if the Miracast Cursor Image Channel is enabled.</returns>
    public extern bool IsEnabled { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Controls the maximum width and height of the cursor image PNG bitmap, in pixels.</summary>
    /// <returns>The maximum width and height of the cursor image PNG bitmap, in pixels.</returns>
    public extern SizeInt32 MaxImageSize { [MethodImpl] get; [MethodImpl] set; }
  }
}
