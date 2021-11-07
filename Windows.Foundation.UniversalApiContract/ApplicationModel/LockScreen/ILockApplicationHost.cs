// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.LockScreen.ILockApplicationHost
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.LockScreen
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(955134381, 55631, 20092, 129, 250, 79, 68, 54, 80, 98, 129)]
  [ExclusiveTo(typeof (LockApplicationHost))]
  internal interface ILockApplicationHost
  {
    void RequestUnlock();

    event TypedEventHandler<LockApplicationHost, LockScreenUnlockingEventArgs> Unlocking;
  }
}
