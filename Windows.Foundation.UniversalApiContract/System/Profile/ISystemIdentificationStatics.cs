// Decompiled with JetBrains decompiler
// Type: Windows.System.Profile.ISystemIdentificationStatics
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.System.Profile
{
  [ExclusiveTo(typeof (SystemIdentification))]
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  [Guid(1434580010, 54239, 19859, 163, 125, 196, 26, 97, 108, 109, 1)]
  internal interface ISystemIdentificationStatics
  {
    SystemIdentificationInfo GetSystemIdForPublisher();

    SystemIdentificationInfo GetSystemIdForUser(User user);
  }
}
