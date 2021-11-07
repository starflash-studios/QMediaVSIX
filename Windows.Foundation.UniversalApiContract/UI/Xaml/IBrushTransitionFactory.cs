// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.IBrushTransitionFactory
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml
{
  [WebHostHidden]
  [Guid(1035891560, 5076, 20748, 162, 21, 117, 57, 244, 120, 123, 82)]
  [ExclusiveTo(typeof (BrushTransition))]
  [ContractVersion(typeof (UniversalApiContract), 458752)]
  internal interface IBrushTransitionFactory
  {
    BrushTransition CreateInstance(object baseInterface, out object innerInterface);
  }
}
