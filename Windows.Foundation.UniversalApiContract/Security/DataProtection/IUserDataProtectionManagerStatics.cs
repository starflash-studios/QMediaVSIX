// Decompiled with JetBrains decompiler
// Type: Windows.Security.DataProtection.IUserDataProtectionManagerStatics
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.System;

namespace Windows.Security.DataProtection
{
  [ExclusiveTo(typeof (UserDataProtectionManager))]
  [Guid(2541191400, 28110, 20398, 175, 133, 120, 42, 194, 207, 69, 114)]
  [ContractVersion(typeof (UniversalApiContract), 524288)]
  internal interface IUserDataProtectionManagerStatics
  {
    UserDataProtectionManager TryGetDefault();

    UserDataProtectionManager TryGetForUser(User user);
  }
}
