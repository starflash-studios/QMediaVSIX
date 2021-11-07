// Decompiled with JetBrains decompiler
// Type: Windows.UI.Core.ICoreIndependentInputSourceControllerStatics
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.UI.Composition;

namespace Windows.UI.Core
{
  [ExclusiveTo(typeof (CoreIndependentInputSourceController))]
  [ContractVersion(typeof (UniversalApiContract), 851968)]
  [Guid(1054625312, 39562, 22161, 133, 134, 252, 164, 203, 87, 82, 109)]
  internal interface ICoreIndependentInputSourceControllerStatics
  {
    CoreIndependentInputSourceController CreateForVisual(
      Visual visual);

    CoreIndependentInputSourceController CreateForIVisualElement(
      IVisualElement visualElement);
  }
}
