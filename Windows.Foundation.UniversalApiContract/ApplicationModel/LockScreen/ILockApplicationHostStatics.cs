// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.LockScreen.ILockApplicationHostStatics
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.LockScreen
{
  [ExclusiveTo(typeof (LockApplicationHost))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(4103056270, 9175, 20067, 150, 161, 102, 111, 245, 45, 59, 44)]
  internal interface ILockApplicationHostStatics
  {
    LockApplicationHost GetForCurrentView();
  }
}
