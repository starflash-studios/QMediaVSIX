﻿// Decompiled with JetBrains decompiler
// Type: Windows.UI.WindowManagement.IAppWindowStatics
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.WindowManagement
{
  [WebHostHidden]
  [ContractVersion(typeof (UniversalApiContract), 524288)]
  [ExclusiveTo(typeof (AppWindow))]
  [Guid(4280237731, 46953, 20719, 152, 115, 16, 140, 208, 232, 151, 70)]
  internal interface IAppWindowStatics
  {
    [RemoteAsync]
    IAsyncOperation<AppWindow> TryCreateAsync();

    void ClearAllPersistedState();

    void ClearPersistedState(string key);
  }
}