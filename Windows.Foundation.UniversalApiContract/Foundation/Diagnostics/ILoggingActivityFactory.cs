// Decompiled with JetBrains decompiler
// Type: Windows.Foundation.Diagnostics.ILoggingActivityFactory
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation.Metadata;

namespace Windows.Foundation.Diagnostics
{
  [ExclusiveTo(typeof (LoggingActivity))]
  [Guid(1798550659, 57610, 19544, 151, 213, 16, 251, 69, 16, 116, 251)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface ILoggingActivityFactory
  {
    LoggingActivity CreateLoggingActivity(
      string activityName,
      ILoggingChannel loggingChannel);

    LoggingActivity CreateLoggingActivityWithLevel(
      string activityName,
      ILoggingChannel loggingChannel,
      LoggingLevel level);
  }
}
