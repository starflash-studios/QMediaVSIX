// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Store.Preview.IStoreConfigurationStatics5
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.System;

namespace Windows.ApplicationModel.Store.Preview
{
  [Guid(4150342033, 36777, 18907, 130, 43, 1, 96, 231, 228, 229, 197)]
  [ContractVersion(typeof (UniversalApiContract), 458752)]
  [ExclusiveTo(typeof (StoreConfiguration))]
  internal interface IStoreConfigurationStatics5
  {
    bool IsPinToDesktopSupported();

    bool IsPinToTaskbarSupported();

    bool IsPinToStartSupported();

    void PinToDesktop(string appPackageFamilyName);

    void PinToDesktopForUser(User user, string appPackageFamilyName);
  }
}
