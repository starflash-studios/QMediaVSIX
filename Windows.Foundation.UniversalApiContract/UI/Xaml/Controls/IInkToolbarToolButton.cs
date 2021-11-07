// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.IInkToolbarToolButton
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Controls
{
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  [Guid(1549464606, 52407, 17496, 128, 100, 169, 132, 157, 49, 86, 27)]
  [WebHostHidden]
  [ExclusiveTo(typeof (InkToolbarToolButton))]
  internal interface IInkToolbarToolButton
  {
    InkToolbarTool ToolKind { get; }

    bool IsExtensionGlyphShown { get; set; }
  }
}
