// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Preview.Holographic.IHolographicApplicationPreviewStatics
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.ApplicationModel.Activation;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Preview.Holographic
{
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  [Guid(4261643921, 10810, 17833, 162, 8, 123, 237, 105, 25, 25, 243)]
  [ExclusiveTo(typeof (HolographicApplicationPreview))]
  internal interface IHolographicApplicationPreviewStatics
  {
    bool IsCurrentViewPresentedOnHolographicDisplay();

    bool IsHolographicActivation(IActivatedEventArgs activatedEventArgs);
  }
}
