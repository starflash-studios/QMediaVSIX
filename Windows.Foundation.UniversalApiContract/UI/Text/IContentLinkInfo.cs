// Decompiled with JetBrains decompiler
// Type: Windows.UI.Text.IContentLinkInfo
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Text
{
  [ContractVersion(typeof (UniversalApiContract), 393216)]
  [ExclusiveTo(typeof (ContentLinkInfo))]
  [Guid(517285157, 7263, 18635, 179, 53, 120, 181, 10, 46, 230, 66)]
  internal interface IContentLinkInfo
  {
    uint Id { get; set; }

    string DisplayText { get; set; }

    string SecondaryText { get; set; }

    Uri Uri { get; set; }

    string LinkContentKind { get; set; }
  }
}
