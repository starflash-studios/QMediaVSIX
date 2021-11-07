// Decompiled with JetBrains decompiler
// Type: Windows.Foundation.Diagnostics.ILoggingOptions
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System;
using Windows.Foundation.Metadata;

namespace Windows.Foundation.Diagnostics
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (LoggingOptions))]
  [Guid(2428270672, 402, 20317, 172, 38, 0, 106, 218, 202, 18, 216)]
  internal interface ILoggingOptions
  {
    long Keywords { get; set; }

    int Tags { get; set; }

    short Task { get; set; }

    LoggingOpcode Opcode { get; set; }

    Guid ActivityId { get; set; }

    Guid RelatedActivityId { get; set; }
  }
}
