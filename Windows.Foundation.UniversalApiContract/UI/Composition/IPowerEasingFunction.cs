// Decompiled with JetBrains decompiler
// Type: Windows.UI.Composition.IPowerEasingFunction
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Composition
{
  [WebHostHidden]
  [ContractVersion(typeof (UniversalApiContract), 786432)]
  [Guid(3288290262, 5003, 22549, 137, 26, 183, 246, 21, 204, 197, 99)]
  [ExclusiveTo(typeof (PowerEasingFunction))]
  internal interface IPowerEasingFunction
  {
    CompositionEasingFunctionMode Mode { get; }

    float Power { get; }
  }
}
