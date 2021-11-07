// Decompiled with JetBrains decompiler
// Type: Windows.System.IKnownUserPropertiesStatics2
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.System
{
  [ContractVersion(typeof (UniversalApiContract), 917504)]
  [ExclusiveTo(typeof (KnownUserProperties))]
  [Guid(1531250562, 63008, 22398, 177, 179, 221, 86, 100, 77, 121, 177)]
  internal interface IKnownUserPropertiesStatics2
  {
    string AgeEnforcementRegion { get; }
  }
}
