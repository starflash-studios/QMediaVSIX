// Decompiled with JetBrains decompiler
// Type: Windows.UI.Composition.IScalarNaturalMotionAnimation
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Composition
{
  [Guid(2494121345, 49042, 18779, 181, 189, 210, 198, 89, 67, 7, 55)]
  [ExclusiveTo(typeof (ScalarNaturalMotionAnimation))]
  [ContractVersion(typeof (UniversalApiContract), 327680)]
  [WebHostHidden]
  internal interface IScalarNaturalMotionAnimation
  {
    IReference<float> FinalValue { get; set; }

    IReference<float> InitialValue { get; set; }

    float InitialVelocity { get; set; }
  }
}
