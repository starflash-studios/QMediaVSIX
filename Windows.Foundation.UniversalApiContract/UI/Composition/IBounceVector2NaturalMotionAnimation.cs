// Decompiled with JetBrains decompiler
// Type: Windows.UI.Composition.IBounceVector2NaturalMotionAnimation
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Composition
{
  [WebHostHidden]
  [ContractVersion(typeof (UniversalApiContract), 393216)]
  [ExclusiveTo(typeof (BounceVector2NaturalMotionAnimation))]
  [Guid(3660857750, 8532, 19260, 136, 170, 71, 54, 18, 4, 236, 205)]
  internal interface IBounceVector2NaturalMotionAnimation
  {
    float Acceleration { get; set; }

    float Restitution { get; set; }
  }
}
