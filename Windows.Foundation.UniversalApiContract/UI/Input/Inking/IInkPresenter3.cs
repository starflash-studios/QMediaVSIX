// Decompiled with JetBrains decompiler
// Type: Windows.UI.Input.Inking.IInkPresenter3
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Input.Inking
{
  [ContractVersion(typeof (UniversalApiContract), 393216)]
  [ExclusiveTo(typeof (InkPresenter))]
  [Guid(1373752969, 54141, 19088, 131, 252, 127, 94, 157, 251, 242, 23)]
  internal interface IInkPresenter3
  {
    InkInputConfiguration InputConfiguration { get; }
  }
}
