// Decompiled with JetBrains decompiler
// Type: Windows.Foundation.Diagnostics.ILoggingChannelFactory
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation.Metadata;

namespace Windows.Foundation.Diagnostics
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(1323064220, 44928, 19099, 176, 220, 57, 143, 154, 229, 32, 123)]
  [ExclusiveTo(typeof (LoggingChannel))]
  internal interface ILoggingChannelFactory
  {
    [Deprecated("This constructor creates a LoggingChannel in Windows 8.1 compatibility mode. Prefer the two-parameter constructor.", DeprecationType.Deprecate, 65536, "Windows.Foundation.UniversalApiContract")]
    LoggingChannel Create(string name);
  }
}
