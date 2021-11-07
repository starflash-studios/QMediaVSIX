// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.IAutoSuggestBox4
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Controls
{
  [ExclusiveTo(typeof (AutoSuggestBox))]
  [WebHostHidden]
  [Guid(3257792663, 41960, 20561, 179, 204, 181, 240, 245, 38, 41, 80)]
  [ContractVersion(typeof (UniversalApiContract), 458752)]
  internal interface IAutoSuggestBox4
  {
    object Description { get; set; }
  }
}
