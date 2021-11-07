// Decompiled with JetBrains decompiler
// Type: Windows.UI.Composition.ISpringScalarNaturalMotionAnimation
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Composition
{
  [WebHostHidden]
  [ContractVersion(typeof (UniversalApiContract), 327680)]
  [ExclusiveTo(typeof (SpringScalarNaturalMotionAnimation))]
  [Guid(91400543, 14329, 20414, 184, 123, 92, 208, 58, 137, 80, 28)]
  internal interface ISpringScalarNaturalMotionAnimation
  {
    float DampingRatio { get; set; }

    TimeSpan Period { get; set; }
  }
}
