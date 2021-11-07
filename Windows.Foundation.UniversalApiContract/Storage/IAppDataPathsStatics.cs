// Decompiled with JetBrains decompiler
// Type: Windows.Storage.IAppDataPathsStatics
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.System;

namespace Windows.Storage
{
  [ContractVersion(typeof (UniversalApiContract), 327680)]
  [ExclusiveTo(typeof (AppDataPaths))]
  [Guid(3639290622, 43481, 19220, 185, 153, 227, 146, 19, 121, 217, 3)]
  internal interface IAppDataPathsStatics
  {
    AppDataPaths GetForUser(User user);

    AppDataPaths GetDefault();
  }
}
