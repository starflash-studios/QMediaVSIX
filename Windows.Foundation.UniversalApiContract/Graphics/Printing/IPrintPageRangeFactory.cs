﻿// Decompiled with JetBrains decompiler
// Type: Windows.Graphics.Printing.IPrintPageRangeFactory
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Graphics.Printing
{
  [Guid(1083167839, 57415, 24453, 113, 41, 251, 8, 90, 79, 173, 20)]
  [ExclusiveTo(typeof (PrintPageRange))]
  [ContractVersion(typeof (UniversalApiContract), 393216)]
  internal interface IPrintPageRangeFactory
  {
    PrintPageRange Create(int firstPage, int lastPage);

    PrintPageRange CreateWithSinglePage(int page);
  }
}