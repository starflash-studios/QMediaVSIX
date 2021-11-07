// Decompiled with JetBrains decompiler
// Type: Windows.UI.Composition.IBounceScalarNaturalMotionAnimation
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Composition
{
  [ContractVersion(typeof (UniversalApiContract), 393216)]
  [WebHostHidden]
  [ExclusiveTo(typeof (BounceScalarNaturalMotionAnimation))]
  [Guid(3131248076, 42547, 17944, 155, 6, 127, 124, 114, 200, 124, 255)]
  internal interface IBounceScalarNaturalMotionAnimation
  {
    float Acceleration { get; set; }

    float Restitution { get; set; }
  }
}
