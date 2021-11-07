// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Documents.ITextElement3
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Documents
{
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  [WebHostHidden]
  [ExclusiveTo(typeof (TextElement))]
  [Guid(3520803855, 7108, 19624, 188, 247, 119, 11, 255, 155, 39, 171)]
  internal interface ITextElement3
  {
    bool AllowFocusOnInteraction { get; set; }

    string AccessKey { get; set; }

    bool ExitDisplayModeOnAccessKeyInvoked { get; set; }
  }
}
