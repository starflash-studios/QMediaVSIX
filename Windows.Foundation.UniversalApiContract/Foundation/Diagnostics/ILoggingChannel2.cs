// Decompiled with JetBrains decompiler
// Type: Windows.Foundation.Diagnostics.ILoggingChannel2
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System;
using Windows.Foundation.Metadata;

namespace Windows.Foundation.Diagnostics
{
  [ExclusiveTo(typeof (LoggingChannel))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(2672573683, 2988, 17829, 158, 51, 186, 243, 243, 162, 70, 165)]
  internal interface ILoggingChannel2 : ILoggingChannel, IClosable, ILoggingTarget
  {
    Guid Id { get; }
  }
}
