// Decompiled with JetBrains decompiler
// Type: Windows.Graphics.Printing.IStandardPrintTaskOptionsStatic3
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Graphics.Printing
{
  [Guid(3153497734, 14424, 16819, 167, 153, 85, 221, 152, 136, 212, 117)]
  [ExclusiveTo(typeof (StandardPrintTaskOptions))]
  [ContractVersion(typeof (UniversalApiContract), 393216)]
  internal interface IStandardPrintTaskOptionsStatic3
  {
    string CustomPageRanges { get; }
  }
}
