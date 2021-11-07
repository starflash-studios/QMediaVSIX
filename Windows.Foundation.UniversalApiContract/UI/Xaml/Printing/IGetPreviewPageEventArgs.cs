// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Printing.IGetPreviewPageEventArgs
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Printing
{
  [ExclusiveTo(typeof (GetPreviewPageEventArgs))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(2755489853, 57001, 19958, 167, 237, 53, 4, 156, 212, 133, 199)]
  [WebHostHidden]
  internal interface IGetPreviewPageEventArgs
  {
    int PageNumber { get; }
  }
}
