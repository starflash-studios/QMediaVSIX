// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Documents.ITextElement2
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Documents
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (TextElement))]
  [Guid(2819058344, 63634, 18934, 140, 210, 137, 173, 218, 240, 109, 45)]
  [WebHostHidden]
  internal interface ITextElement2
  {
    bool IsTextScaleFactorEnabled { get; set; }
  }
}
