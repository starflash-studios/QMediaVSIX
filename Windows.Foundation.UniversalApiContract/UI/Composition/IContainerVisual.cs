// Decompiled with JetBrains decompiler
// Type: Windows.UI.Composition.IContainerVisual
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Composition
{
  [Guid(49724532, 60704, 18291, 175, 230, 212, 155, 74, 147, 219, 50)]
  [WebHostHidden]
  [ContractVersion(typeof (UniversalApiContract), 131072)]
  [ExclusiveTo(typeof (ContainerVisual))]
  internal interface IContainerVisual
  {
    VisualCollection Children { get; }
  }
}
