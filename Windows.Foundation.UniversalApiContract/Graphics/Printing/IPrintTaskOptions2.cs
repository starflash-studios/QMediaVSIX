﻿// Decompiled with JetBrains decompiler
// Type: Windows.Graphics.Printing.IPrintTaskOptions2
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.Graphics.Printing
{
  [ContractVersion(typeof (UniversalApiContract), 393216)]
  [ExclusiveTo(typeof (PrintTaskOptions))]
  [Guid(3952809478, 39478, 19289, 134, 23, 178, 23, 132, 146, 98, 225)]
  internal interface IPrintTaskOptions2
  {
    PrintPageRangeOptions PageRangeOptions { get; }

    IVector<PrintPageRange> CustomPageRanges { get; }
  }
}