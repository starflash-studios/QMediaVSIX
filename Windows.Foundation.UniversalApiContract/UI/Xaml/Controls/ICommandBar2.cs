// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.ICommandBar2
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml.Controls.Primitives;

namespace Windows.UI.Xaml.Controls
{
  [Guid(1466314584, 23346, 18269, 190, 100, 76, 163, 110, 123, 151, 212)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (CommandBar))]
  [WebHostHidden]
  internal interface ICommandBar2
  {
    Style CommandBarOverflowPresenterStyle { get; set; }

    CommandBarTemplateSettings CommandBarTemplateSettings { get; }
  }
}
