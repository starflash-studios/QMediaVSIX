// Decompiled with JetBrains decompiler
// Type: Windows.System.IAppUriHandlerRegistrationManagerStatics2
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.System
{
  [ExclusiveTo(typeof (AppUriHandlerRegistrationManager))]
  [Guid(351765369, 26768, 20608, 144, 167, 152, 130, 74, 127, 7, 158)]
  [ContractVersion(typeof (UniversalApiContract), 851968)]
  internal interface IAppUriHandlerRegistrationManagerStatics2
  {
    AppUriHandlerRegistrationManager GetForPackage(
      string packageFamilyName);

    AppUriHandlerRegistrationManager GetForPackageForUser(
      string packageFamilyName,
      User user);
  }
}
