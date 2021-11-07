// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.IScalarTransitionFactory
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml
{
  [ContractVersion(typeof (UniversalApiContract), 458752)]
  [Guid(3383880174, 37082, 24029, 190, 100, 62, 71, 151, 126, 162, 128)]
  [ExclusiveTo(typeof (ScalarTransition))]
  [WebHostHidden]
  internal interface IScalarTransitionFactory
  {
    ScalarTransition CreateInstance(object baseInterface, out object innerInterface);
  }
}
