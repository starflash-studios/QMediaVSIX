﻿// Decompiled with JetBrains decompiler
// Type: Windows.Media.Core.ITimedTextStyle2
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Media.Core
{
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  [ExclusiveTo(typeof (TimedTextStyle))]
  [Guid(1700743469, 24849, 18311, 137, 204, 104, 111, 236, 229, 126, 20)]
  internal interface ITimedTextStyle2
  {
    TimedTextFontStyle FontStyle { get; set; }

    bool IsUnderlineEnabled { get; set; }

    bool IsLineThroughEnabled { get; set; }

    bool IsOverlineEnabled { get; set; }
  }
}