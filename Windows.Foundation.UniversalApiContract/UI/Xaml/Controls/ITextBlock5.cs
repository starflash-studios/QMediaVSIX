// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.ITextBlock5
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.UI.Text;

namespace Windows.UI.Xaml.Controls
{
  [WebHostHidden]
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  [Guid(1649028408, 60861, 19034, 182, 120, 228, 159, 30, 7, 175, 189)]
  [ExclusiveTo(typeof (TextBlock))]
  internal interface ITextBlock5
  {
    TextDecorations TextDecorations { get; set; }
  }
}
