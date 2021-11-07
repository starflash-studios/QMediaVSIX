// Decompiled with JetBrains decompiler
// Type: Windows.Media.Protection.PlayReady.IPlayReadyStatics4
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Media.Protection.PlayReady
{
  [ExclusiveTo(typeof (PlayReadyStatics))]
  [Guid(1353257728, 55332, 16945, 157, 94, 120, 239, 136, 68, 199, 215)]
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  internal interface IPlayReadyStatics4 : IPlayReadyStatics3, IPlayReadyStatics2, IPlayReadyStatics
  {
    string InputTrustAuthorityToCreate { get; }

    Guid ProtectionSystemId { get; }
  }
}
