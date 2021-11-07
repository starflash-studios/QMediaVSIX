// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.LockScreen.LockScreenBadge
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Storage.Streams;

namespace Windows.ApplicationModel.LockScreen
{
  /// <summary>Represents a lock screen badge for an app.</summary>
  [MarshalingBehavior(MarshalingType.Agile)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [DualApiPartition(version = 167772160)]
  public sealed class LockScreenBadge : ILockScreenBadge
  {
    /// <summary>Gets the logo to display with the badge.</summary>
    /// <returns>The logo.</returns>
    public extern IRandomAccessStream Logo { [MethodImpl] get; }

    /// <summary>Gets the glyph to display.</summary>
    /// <returns>The glyph.</returns>
    public extern IRandomAccessStream Glyph { [MethodImpl] get; }

    /// <summary>Gets the number to display with the badge.</summary>
    /// <returns>The number.</returns>
    public extern IReference<uint> Number { [MethodImpl] get; }

    /// <summary>Gets the name.</summary>
    /// <returns>The name.</returns>
    public extern string AutomationName { [MethodImpl] get; }

    /// <summary>Launches the app corresponding to the badge.</summary>
    [MethodImpl]
    public extern void LaunchApp();
  }
}
