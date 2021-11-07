// Decompiled with JetBrains decompiler
// Type: Windows.UI.Composition.IAnimationControllerStatics
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Composition
{
  [WebHostHidden]
  [ContractVersion(typeof (UniversalApiContract), 393216)]
  [ExclusiveTo(typeof (AnimationController))]
  [Guid(3876676831, 25883, 18432, 185, 229, 106, 59, 207, 237, 51, 101)]
  internal interface IAnimationControllerStatics
  {
    float MaxPlaybackRate { get; }

    float MinPlaybackRate { get; }
  }
}
