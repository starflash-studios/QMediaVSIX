// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.IContentLinkChangedEventArgs
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.UI.Text;
using Windows.UI.Xaml.Documents;

namespace Windows.UI.Xaml.Controls
{
  [Guid(1693708766, 35323, 19319, 139, 155, 25, 27, 109, 25, 41, 10)]
  [ExclusiveTo(typeof (ContentLinkChangedEventArgs))]
  [ContractVersion(typeof (UniversalApiContract), 393216)]
  [WebHostHidden]
  internal interface IContentLinkChangedEventArgs
  {
    ContentLinkChangeKind ChangeKind { get; }

    ContentLinkInfo ContentLinkInfo { get; }

    TextRange TextRange { get; }
  }
}
