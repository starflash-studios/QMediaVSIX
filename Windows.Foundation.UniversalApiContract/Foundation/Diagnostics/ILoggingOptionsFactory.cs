// Decompiled with JetBrains decompiler
// Type: Windows.Foundation.Diagnostics.ILoggingOptionsFactory
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation.Metadata;

namespace Windows.Foundation.Diagnostics
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (LoggingOptions))]
  [Guid(3608397515, 39083, 17995, 159, 34, 163, 38, 132, 120, 54, 138)]
  internal interface ILoggingOptionsFactory
  {
    LoggingOptions CreateWithKeywords(long keywords);
  }
}
