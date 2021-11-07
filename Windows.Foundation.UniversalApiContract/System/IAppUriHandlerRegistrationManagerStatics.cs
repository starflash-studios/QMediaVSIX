// Decompiled with JetBrains decompiler
// Type: Windows.System.IAppUriHandlerRegistrationManagerStatics
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.System
{
  [ExclusiveTo(typeof (AppUriHandlerRegistrationManager))]
  [Guid(3587104159, 22313, 23414, 161, 212, 2, 133, 242, 149, 193, 36)]
  [ContractVersion(typeof (UniversalApiContract), 458752)]
  internal interface IAppUriHandlerRegistrationManagerStatics
  {
    AppUriHandlerRegistrationManager GetDefault();

    AppUriHandlerRegistrationManager GetForUser(User user);
  }
}
