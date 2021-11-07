// Decompiled with JetBrains decompiler
// Type: Windows.Storage.IUserDataPathsStatics
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.System;

namespace Windows.Storage
{
  [ExclusiveTo(typeof (UserDataPaths))]
  [Guid(28483055, 57442, 18593, 139, 12, 242, 199, 169, 202, 86, 192)]
  [ContractVersion(typeof (UniversalApiContract), 327680)]
  internal interface IUserDataPathsStatics
  {
    UserDataPaths GetForUser(User user);

    UserDataPaths GetDefault();
  }
}
