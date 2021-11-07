// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.Primitives.ISelectorItem
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Controls.Primitives
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (SelectorItem))]
  [WebHostHidden]
  [Guid(1411157356, 643, 17793, 185, 69, 42, 100, 194, 138, 6, 70)]
  internal interface ISelectorItem
  {
    bool IsSelected { get; set; }
  }
}
