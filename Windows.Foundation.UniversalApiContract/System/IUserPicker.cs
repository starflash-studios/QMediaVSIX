// Decompiled with JetBrains decompiler
// Type: Windows.System.IUserPicker
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.System
{
  [Guid(2102689800, 61923, 19052, 141, 220, 169, 187, 15, 72, 138, 237)]
  [ExclusiveTo(typeof (UserPicker))]
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  internal interface IUserPicker
  {
    bool AllowGuestAccounts { get; set; }

    User SuggestedSelectedUser { get; set; }

    IAsyncOperation<User> PickSingleUserAsync();
  }
}
