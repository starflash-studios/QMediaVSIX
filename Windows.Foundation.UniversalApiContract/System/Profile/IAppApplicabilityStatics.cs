// Decompiled with JetBrains decompiler
// Type: Windows.System.Profile.IAppApplicabilityStatics
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.System.Profile
{
  [ExclusiveTo(typeof (AppApplicability))]
  [ContractVersion(typeof (UniversalApiContract), 524288)]
  [Guid(375693442, 3896, 23705, 131, 228, 72, 153, 89, 112, 134, 28)]
  internal interface IAppApplicabilityStatics
  {
    IVectorView<UnsupportedAppRequirement> GetUnsupportedAppRequirements(
      IIterable<string> capabilities);
  }
}
