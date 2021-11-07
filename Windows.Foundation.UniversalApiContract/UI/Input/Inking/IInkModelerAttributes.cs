// Decompiled with JetBrains decompiler
// Type: Windows.UI.Input.Inking.IInkModelerAttributes
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Input.Inking
{
  [ExclusiveTo(typeof (InkModelerAttributes))]
  [Guid(3134398247, 3289, 19453, 182, 243, 158, 3, 186, 141, 116, 84)]
  [ContractVersion(typeof (UniversalApiContract), 393216)]
  internal interface IInkModelerAttributes
  {
    TimeSpan PredictionTime { get; set; }

    float ScalingFactor { get; set; }
  }
}
