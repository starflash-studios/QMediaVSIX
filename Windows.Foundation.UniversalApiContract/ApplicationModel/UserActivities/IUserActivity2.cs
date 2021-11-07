// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.UserActivities.IUserActivity2
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.UserActivities
{
  [ContractVersion(typeof (UniversalApiContract), 393216)]
  [Guid(2646871138, 2244, 18348, 170, 156, 43, 178, 34, 28, 85, 253)]
  [ExclusiveTo(typeof (UserActivity))]
  internal interface IUserActivity2
  {
    string ToJson();
  }
}
