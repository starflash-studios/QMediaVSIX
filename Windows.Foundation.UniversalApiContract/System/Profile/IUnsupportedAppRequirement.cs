// Decompiled with JetBrains decompiler
// Type: Windows.System.Profile.IUnsupportedAppRequirement
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.System.Profile
{
  [Guid(1635927132, 35147, 23740, 137, 118, 169, 142, 10, 155, 153, 141)]
  [ContractVersion(typeof (UniversalApiContract), 524288)]
  [ExclusiveTo(typeof (UnsupportedAppRequirement))]
  internal interface IUnsupportedAppRequirement
  {
    string Requirement { get; }

    UnsupportedAppRequirementReasons Reasons { get; }
  }
}
