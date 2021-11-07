// Decompiled with JetBrains decompiler
// Type: Windows.UI.Composition.IBackEasingFunction
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Composition
{
  [ExclusiveTo(typeof (BackEasingFunction))]
  [WebHostHidden]
  [ContractVersion(typeof (UniversalApiContract), 786432)]
  [Guid(3092647332, 24124, 21597, 178, 99, 121, 135, 162, 189, 39, 203)]
  internal interface IBackEasingFunction
  {
    CompositionEasingFunctionMode Mode { get; }

    float Amplitude { get; }
  }
}
