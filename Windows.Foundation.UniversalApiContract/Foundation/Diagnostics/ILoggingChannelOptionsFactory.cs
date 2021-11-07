// Decompiled with JetBrains decompiler
// Type: Windows.Foundation.Diagnostics.ILoggingChannelOptionsFactory
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System;
using Windows.Foundation.Metadata;

namespace Windows.Foundation.Diagnostics
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (LoggingChannelOptions))]
  [Guid(2838581722, 32687, 16785, 135, 85, 94, 134, 220, 101, 216, 150)]
  internal interface ILoggingChannelOptionsFactory
  {
    LoggingChannelOptions Create(Guid group);
  }
}
