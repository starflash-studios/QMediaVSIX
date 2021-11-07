// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.LockScreen.LockScreenUnlockingDeferral
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.LockScreen
{
  /// <summary>Represents an unlock deferral.</summary>
  [MarshalingBehavior(MarshalingType.Agile)]
  [DualApiPartition(version = 167772160)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public sealed class LockScreenUnlockingDeferral : ILockScreenUnlockingDeferral
  {
    /// <summary>Notifies the system that your deferral is complete. If your deferral takes too long to complete, your lock screen app will be terminated by the system and potentially removed as the user’s default lock app.</summary>
    [MethodImpl]
    public extern void Complete();
  }
}
