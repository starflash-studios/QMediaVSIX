// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.UserDataTasks.IUserDataTaskQueryOptions
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.UserDataTasks
{
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  [Guid(2510235629, 37018, 19760, 140, 27, 51, 29, 143, 230, 103, 226)]
  [ExclusiveTo(typeof (UserDataTaskQueryOptions))]
  internal interface IUserDataTaskQueryOptions
  {
    UserDataTaskQuerySortProperty SortProperty { get; set; }

    UserDataTaskQueryKind Kind { get; set; }
  }
}
