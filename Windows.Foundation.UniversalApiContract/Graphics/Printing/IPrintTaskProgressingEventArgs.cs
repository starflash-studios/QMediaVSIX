// Decompiled with JetBrains decompiler
// Type: Windows.Graphics.Printing.IPrintTaskProgressingEventArgs
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Graphics.Printing
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (PrintTaskProgressingEventArgs))]
  [Guid(2165101515, 46096, 17026, 160, 115, 90, 195, 120, 35, 65, 116)]
  internal interface IPrintTaskProgressingEventArgs
  {
    uint DocumentPageCount { get; }
  }
}
