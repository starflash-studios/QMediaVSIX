// Decompiled with JetBrains decompiler
// Type: Windows.UI.Input.Inking.Core.ICoreInkPresenterHost
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.UI.Composition;

namespace Windows.UI.Input.Inking.Core
{
  [WebHostHidden]
  [ContractVersion(typeof (UniversalApiContract), 327680)]
  [ExclusiveTo(typeof (CoreInkPresenterHost))]
  [Guid(963545574, 32085, 17943, 158, 88, 104, 199, 12, 145, 105, 185)]
  internal interface ICoreInkPresenterHost
  {
    InkPresenter InkPresenter { get; }

    ContainerVisual RootVisual { get; set; }
  }
}
