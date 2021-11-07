// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Documents.ITextElementOverrides
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Documents
{
  [WebHostHidden]
  [ExclusiveTo(typeof (TextElement))]
  [Guid(216145639, 20342, 19929, 191, 145, 22, 59, 236, 207, 132, 188)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface ITextElementOverrides
  {
    void OnDisconnectVisualChildren();
  }
}
