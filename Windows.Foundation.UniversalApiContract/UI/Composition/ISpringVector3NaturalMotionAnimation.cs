// Decompiled with JetBrains decompiler
// Type: Windows.UI.Composition.ISpringVector3NaturalMotionAnimation
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Composition
{
  [ExclusiveTo(typeof (SpringVector3NaturalMotionAnimation))]
  [WebHostHidden]
  [Guid(1820805599, 54651, 18324, 142, 45, 206, 203, 17, 225, 148, 229)]
  [ContractVersion(typeof (UniversalApiContract), 327680)]
  internal interface ISpringVector3NaturalMotionAnimation
  {
    float DampingRatio { get; set; }

    TimeSpan Period { get; set; }
  }
}
