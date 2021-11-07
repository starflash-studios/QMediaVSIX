// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.UserDataAccounts.IUserDataAccountManagerStatics2
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.System;

namespace Windows.ApplicationModel.UserDataAccounts
{
  [ExclusiveTo(typeof (UserDataAccountManager))]
  [Guid(1782443400, 12651, 17246, 181, 52, 247, 212, 180, 183, 219, 166)]
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  internal interface IUserDataAccountManagerStatics2
  {
    UserDataAccountManagerForUser GetForUser(User user);
  }
}
