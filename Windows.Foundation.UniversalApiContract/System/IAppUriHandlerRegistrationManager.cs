// Decompiled with JetBrains decompiler
// Type: Windows.System.IAppUriHandlerRegistrationManager
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.System
{
  [Guid(3861682770, 44180, 22352, 172, 27, 108, 251, 111, 37, 2, 99)]
  [ContractVersion(typeof (UniversalApiContract), 458752)]
  [ExclusiveTo(typeof (AppUriHandlerRegistrationManager))]
  internal interface IAppUriHandlerRegistrationManager
  {
    User User { get; }

    AppUriHandlerRegistration TryGetRegistration(string name);
  }
}
