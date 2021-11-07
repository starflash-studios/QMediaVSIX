// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Printing.IPaginateEventArgs
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Graphics.Printing;

namespace Windows.UI.Xaml.Printing
{
  [Guid(3985924054, 31147, 17079, 147, 10, 61, 110, 9, 1, 29, 33)]
  [ExclusiveTo(typeof (PaginateEventArgs))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [WebHostHidden]
  internal interface IPaginateEventArgs
  {
    PrintTaskOptions PrintTaskOptions { get; }

    int CurrentPreviewPageNumber { get; }
  }
}
