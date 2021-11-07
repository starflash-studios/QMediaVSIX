// Decompiled with JetBrains decompiler
// Type: Windows.Foundation.Diagnostics.ILoggingSessionFactory
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation.Metadata;

namespace Windows.Foundation.Diagnostics
{
  [Guid(1318289125, 22781, 17888, 140, 47, 161, 50, 239, 249, 92, 30)]
  [ExclusiveTo(typeof (LoggingSession))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface ILoggingSessionFactory
  {
    LoggingSession Create(string name);
  }
}
