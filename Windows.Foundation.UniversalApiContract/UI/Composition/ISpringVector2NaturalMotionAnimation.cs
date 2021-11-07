// Decompiled with JetBrains decompiler
// Type: Windows.UI.Composition.ISpringVector2NaturalMotionAnimation
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Composition
{
  [Guid(603231413, 61043, 20239, 164, 35, 64, 43, 148, 109, 244, 179)]
  [WebHostHidden]
  [ExclusiveTo(typeof (SpringVector2NaturalMotionAnimation))]
  [ContractVersion(typeof (UniversalApiContract), 327680)]
  internal interface ISpringVector2NaturalMotionAnimation
  {
    float DampingRatio { get; set; }

    TimeSpan Period { get; set; }
  }
}
