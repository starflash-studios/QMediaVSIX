// Decompiled with JetBrains decompiler
// Type: Windows.UI.Composition.IVector3NaturalMotionAnimation
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Foundation.Numerics;

namespace Windows.UI.Composition
{
  [ExclusiveTo(typeof (Vector3NaturalMotionAnimation))]
  [Guid(2618754092, 58058, 17837, 150, 158, 78, 120, 183, 185, 173, 65)]
  [ContractVersion(typeof (UniversalApiContract), 327680)]
  [WebHostHidden]
  internal interface IVector3NaturalMotionAnimation
  {
    IReference<Vector3> FinalValue { get; set; }

    IReference<Vector3> InitialValue { get; set; }

    Vector3 InitialVelocity { get; set; }
  }
}
