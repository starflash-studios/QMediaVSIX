// Decompiled with JetBrains decompiler
// Type: Windows.Foundation.Diagnostics.ILoggingActivity2
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation.Metadata;

namespace Windows.Foundation.Diagnostics
{
  [ExclusiveTo(typeof (LoggingActivity))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(650287112, 25378, 17770, 175, 130, 128, 200, 100, 47, 23, 139)]
  internal interface ILoggingActivity2 : ILoggingActivity, IClosable, ILoggingTarget
  {
    LoggingChannel Channel { get; }

    [Overload("StopActivity")]
    void StopActivity(string stopEventName);

    [Overload("StopActivityWithFields")]
    void StopActivity(string stopEventName, LoggingFields fields);

    [Overload("StopActivityWithFieldsAndOptions")]
    void StopActivity(string stopEventName, LoggingFields fields, LoggingOptions options);
  }
}
