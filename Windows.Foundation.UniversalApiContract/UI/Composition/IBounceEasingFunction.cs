// Decompiled with JetBrains decompiler
// Type: Windows.UI.Composition.IBounceEasingFunction
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Composition
{
  [ExclusiveTo(typeof (BounceEasingFunction))]
  [Guid(3892163659, 43733, 20852, 148, 33, 238, 248, 183, 90, 106, 67)]
  [WebHostHidden]
  [ContractVersion(typeof (UniversalApiContract), 786432)]
  internal interface IBounceEasingFunction
  {
    CompositionEasingFunctionMode Mode { get; }

    int Bounces { get; }

    float Bounciness { get; }
  }
}
