// Decompiled with JetBrains decompiler
// Type: Windows.UI.Composition.IVector2NaturalMotionAnimation
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Foundation.Numerics;

namespace Windows.UI.Composition
{
  [WebHostHidden]
  [Guid(255724413, 58642, 18333, 160, 12, 119, 201, 58, 48, 163, 149)]
  [ExclusiveTo(typeof (Vector2NaturalMotionAnimation))]
  [ContractVersion(typeof (UniversalApiContract), 327680)]
  internal interface IVector2NaturalMotionAnimation
  {
    IReference<Vector2> FinalValue { get; set; }

    IReference<Vector2> InitialValue { get; set; }

    Vector2 InitialVelocity { get; set; }
  }
}
