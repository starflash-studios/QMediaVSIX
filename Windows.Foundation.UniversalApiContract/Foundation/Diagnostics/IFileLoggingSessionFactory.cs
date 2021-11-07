// Decompiled with JetBrains decompiler
// Type: Windows.Foundation.Diagnostics.IFileLoggingSessionFactory
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation.Metadata;

namespace Windows.Foundation.Diagnostics
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(4003499470, 33863, 19882, 145, 51, 18, 235, 70, 246, 151, 212)]
  [ExclusiveTo(typeof (FileLoggingSession))]
  internal interface IFileLoggingSessionFactory
  {
    FileLoggingSession Create(string name);
  }
}
