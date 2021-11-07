// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.LockScreen.ILockScreenUnlockingEventArgs
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.LockScreen
{
  [Guid(1155973127, 30203, 19131, 159, 139, 130, 71, 72, 144, 12, 113)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (LockScreenUnlockingEventArgs))]
  internal interface ILockScreenUnlockingEventArgs
  {
    LockScreenUnlockingDeferral GetDeferral();

    DateTime Deadline { get; }
  }
}
