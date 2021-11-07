// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.LockScreen.LockScreenUnlockingEventArgs
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.LockScreen
{
  /// <summary>Represents the lock screen unlocking events.</summary>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [DualApiPartition(version = 167772160)]
  [MarshalingBehavior(MarshalingType.Agile)]
  public sealed class LockScreenUnlockingEventArgs : ILockScreenUnlockingEventArgs
  {
    /// <summary>Gets a LockScreenUnlockingDeferral, which defers the unlocking of the device.</summary>
    /// <returns>An unlock deferral.</returns>
    [MethodImpl]
    public extern LockScreenUnlockingDeferral GetDeferral();

    /// <summary>Gets the deadline by which the lock screen app must unlock the device. If your unlocking deferral takes too long, your lock screen app will be terminated by the system and potentially removed as the user’s default lock app.</summary>
    /// <returns>The deadline by which your app must unlock the device.</returns>
    public extern DateTime Deadline { [MethodImpl] get; }
  }
}
