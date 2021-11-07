// Decompiled with JetBrains decompiler
// Type: Windows.Media.Protection.PlayReady.IPlayReadyLicense2
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Media.Protection.PlayReady
{
  [Guid(821356455, 55523, 18592, 188, 218, 255, 159, 64, 83, 4, 54)]
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  [ExclusiveTo(typeof (PlayReadyLicense))]
  internal interface IPlayReadyLicense2 : IPlayReadyLicense
  {
    Guid SecureStopId { get; }

    uint SecurityLevel { get; }

    bool InMemoryOnly { get; }

    bool ExpiresInRealTime { get; }
  }
}
