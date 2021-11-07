// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Documents.ITextElement5
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Documents
{
  [ExclusiveTo(typeof (TextElement))]
  [ContractVersion(typeof (UniversalApiContract), 524288)]
  [WebHostHidden]
  [Guid(3180679923, 21517, 22719, 182, 168, 7, 85, 106, 237, 162, 234)]
  internal interface ITextElement5
  {
    XamlRoot XamlRoot { get; set; }
  }
}
