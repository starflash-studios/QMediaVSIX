// Decompiled with JetBrains decompiler
// Type: Windows.Foundation.Diagnostics.ILoggingActivity
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System;
using Windows.Foundation.Metadata;

namespace Windows.Foundation.Diagnostics
{
  [ExclusiveTo(typeof (LoggingActivity))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(3154323777, 46950, 19637, 152, 72, 151, 172, 107, 166, 214, 12)]
  internal interface ILoggingActivity : IClosable
  {
    string Name { get; }

    Guid Id { get; }
  }
}
