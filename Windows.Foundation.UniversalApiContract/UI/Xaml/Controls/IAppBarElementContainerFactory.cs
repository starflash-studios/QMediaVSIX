// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.IAppBarElementContainerFactory
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Controls
{
  [Guid(3037090574, 34967, 23919, 164, 62, 240, 88, 99, 56, 210, 130)]
  [ExclusiveTo(typeof (AppBarElementContainer))]
  [WebHostHidden]
  [ContractVersion(typeof (UniversalApiContract), 458752)]
  internal interface IAppBarElementContainerFactory
  {
    AppBarElementContainer CreateInstance(
      object baseInterface,
      out object innerInterface);
  }
}
