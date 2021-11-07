// Decompiled with JetBrains decompiler
// Type: Windows.UI.Composition.IBounceVector3NaturalMotionAnimation
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Composition
{
  [ContractVersion(typeof (UniversalApiContract), 393216)]
  [ExclusiveTo(typeof (BounceVector3NaturalMotionAnimation))]
  [WebHostHidden]
  [Guid(1205517361, 4307, 17688, 134, 241, 9, 202, 247, 66, 209, 19)]
  internal interface IBounceVector3NaturalMotionAnimation
  {
    float Acceleration { get; set; }

    float Restitution { get; set; }
  }
}
