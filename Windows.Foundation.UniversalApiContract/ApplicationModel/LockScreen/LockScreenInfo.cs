// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.LockScreen.LockScreenInfo
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
using Windows.Storage.Streams;

namespace Windows.ApplicationModel.LockScreen
{
  /// <summary>Provides access to the same data that the default lock screen has access to, such as wallpaper, badges, and so on.</summary>
  [MarshalingBehavior(MarshalingType.Agile)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [DualApiPartition(version = 167772160)]
  public sealed class LockScreenInfo : ILockScreenInfo
  {
    /// <summary>Indicates the lock screen image has changed.</summary>
    public extern event TypedEventHandler<LockScreenInfo, object> LockScreenImageChanged;

    /// <summary>Gets the image to display on the lock screen.</summary>
    /// <returns>The image to display.</returns>
    public extern IRandomAccessStream LockScreenImage { [MethodImpl] get; }

    /// <summary>Indicates the badges have changed.</summary>
    public extern event TypedEventHandler<LockScreenInfo, object> BadgesChanged;

    /// <summary>Gets the badges to display.</summary>
    /// <returns>The badges.</returns>
    public extern IVectorView<LockScreenBadge> Badges { [MethodImpl] get; }

    /// <summary>Indicates the detail text has changed.</summary>
    public extern event TypedEventHandler<LockScreenInfo, object> DetailTextChanged;

    /// <summary>Gets the detail text to display.</summary>
    /// <returns>The text.</returns>
    public extern IVectorView<string> DetailText { [MethodImpl] get; }

    /// <summary>Indicates the alarm icon has changed.</summary>
    public extern event TypedEventHandler<LockScreenInfo, object> AlarmIconChanged;

    /// <summary>Gets the alarm icon to display.</summary>
    /// <returns>The alarm icon.</returns>
    public extern IRandomAccessStream AlarmIcon { [MethodImpl] get; }
  }
}
