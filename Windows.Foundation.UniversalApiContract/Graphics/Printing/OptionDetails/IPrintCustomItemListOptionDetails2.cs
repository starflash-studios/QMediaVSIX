﻿// Decompiled with JetBrains decompiler
// Type: Windows.Graphics.Printing.OptionDetails.IPrintCustomItemListOptionDetails2
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Storage.Streams;

namespace Windows.Graphics.Printing.OptionDetails
{
  [Guid(3386258749, 25884, 19001, 144, 110, 16, 145, 161, 128, 27, 241)]
  [ContractVersion(typeof (UniversalApiContract), 393216)]
  [ExclusiveTo(typeof (PrintCustomItemListOptionDetails))]
  internal interface IPrintCustomItemListOptionDetails2
  {
    void AddItem(
      string itemId,
      string displayName,
      string description,
      IRandomAccessStreamWithContentType icon);
  }
}