// Decompiled with JetBrains decompiler
// Type: Windows.UI.Composition.ICompositor3
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Composition
{
  [ExclusiveTo(typeof (Compositor))]
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  [Guid(3386740464, 28337, 20028, 166, 88, 103, 93, 156, 100, 212, 171)]
  [WebHostHidden]
  internal interface ICompositor3
  {
    CompositionBackdropBrush CreateHostBackdropBrush();
  }
}
