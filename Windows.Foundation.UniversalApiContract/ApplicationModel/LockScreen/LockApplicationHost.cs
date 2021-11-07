// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.LockScreen.LockApplicationHost
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.LockScreen
{
  /// <summary>Allows the lock screen app to request that the device unlocks, and allows the app to register to be notified when the device begins to unlock.</summary>
  [DualApiPartition(version = 167772160)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Static(typeof (ILockApplicationHostStatics), 65536, "Windows.Foundation.UniversalApiContract")]
  [MarshalingBehavior(MarshalingType.Agile)]
  public sealed class LockApplicationHost : ILockApplicationHost
  {
    /// <summary>Requests that the device unlocks.</summary>
    [MethodImpl]
    public extern void RequestUnlock();

    /// <summary>Indicates the device is unlocking.</summary>
    public extern event TypedEventHandler<LockApplicationHost, LockScreenUnlockingEventArgs> Unlocking;

    /// <summary>Gets a LockApplicationHost object.</summary>
    /// <returns>A LockApplicationHost object.</returns>
    [MethodImpl]
    public static extern LockApplicationHost GetForCurrentView();
  }
}
