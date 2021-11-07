// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.IInkToolbarStencilButtonFactory
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Controls
{
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  [WebHostHidden]
  [Guid(2718368209, 35440, 19831, 137, 212, 23, 48, 163, 165, 142, 223)]
  [ExclusiveTo(typeof (InkToolbarStencilButton))]
  internal interface IInkToolbarStencilButtonFactory
  {
    InkToolbarStencilButton CreateInstance(
      object baseInterface,
      out object innerInterface);
  }
}
