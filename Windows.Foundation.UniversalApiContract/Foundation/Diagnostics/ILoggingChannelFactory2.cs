// Decompiled with JetBrains decompiler
// Type: Windows.Foundation.Diagnostics.ILoggingChannelFactory2
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System;
using Windows.Foundation.Metadata;

namespace Windows.Foundation.Diagnostics
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (LoggingChannel))]
  [Guid(1282340317, 15143, 19913, 153, 240, 41, 156, 110, 70, 3, 161)]
  internal interface ILoggingChannelFactory2
  {
    LoggingChannel CreateWithOptions(string name, LoggingChannelOptions options);

    LoggingChannel CreateWithOptionsAndId(
      string name,
      LoggingChannelOptions options,
      Guid id);
  }
}
