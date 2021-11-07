// Decompiled with JetBrains decompiler
// Type: Windows.Graphics.Holographic.IHolographicDisplayStatics
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Graphics.Holographic
{
  [Guid(3409398147, 59312, 18497, 131, 85, 58, 229, 181, 54, 233, 164)]
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  [ExclusiveTo(typeof (HolographicDisplay))]
  internal interface IHolographicDisplayStatics
  {
    HolographicDisplay GetDefault();
  }
}
