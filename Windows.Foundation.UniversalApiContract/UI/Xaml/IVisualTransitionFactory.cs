// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.IVisualTransitionFactory
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml
{
  [ExclusiveTo(typeof (VisualTransition))]
  [Guid(3933570639, 53728, 19886, 180, 41, 137, 252, 50, 39, 36, 244)]
  [WebHostHidden]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IVisualTransitionFactory
  {
    VisualTransition CreateInstance(object baseInterface, out object innerInterface);
  }
}
