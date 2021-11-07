// Decompiled with JetBrains decompiler
// Type: Windows.Graphics.Holographic.IHolographicCamera4
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Graphics.Holographic
{
  [Guid(2586128854, 18211, 20281, 169, 165, 157, 5, 24, 29, 155, 68)]
  [ExclusiveTo(typeof (HolographicCamera))]
  [ContractVersion(typeof (UniversalApiContract), 393216)]
  internal interface IHolographicCamera4
  {
    bool CanOverrideViewport { get; }
  }
}
