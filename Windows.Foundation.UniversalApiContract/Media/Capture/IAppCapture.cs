﻿// Decompiled with JetBrains decompiler
// Type: Windows.Media.Capture.IAppCapture
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Media.Capture
{
  [Guid(2538198099, 41626, 17901, 143, 41, 34, 208, 153, 66, 207, 247)]
  [ContractVersion(typeof (UniversalApiContract), 131072)]
  [ExclusiveTo(typeof (AppCapture))]
  internal interface IAppCapture
  {
    bool IsCapturingAudio { get; }

    bool IsCapturingVideo { get; }

    event TypedEventHandler<AppCapture, object> CapturingChanged;
  }
}