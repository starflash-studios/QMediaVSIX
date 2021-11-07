// Decompiled with JetBrains decompiler
// Type: Windows.UI.Composition.IStepEasingFunction
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Composition
{
  [WebHostHidden]
  [ExclusiveTo(typeof (StepEasingFunction))]
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  [Guid(3502942027, 22028, 18955, 165, 246, 32, 108, 168, 195, 236, 214)]
  internal interface IStepEasingFunction
  {
    int FinalStep { get; set; }

    int InitialStep { get; set; }

    bool IsFinalStepSingleFrame { get; set; }

    bool IsInitialStepSingleFrame { get; set; }

    int StepCount { get; set; }
  }
}
