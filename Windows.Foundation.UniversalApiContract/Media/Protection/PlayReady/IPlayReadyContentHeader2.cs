// Decompiled with JetBrains decompiler
// Type: Windows.Media.Protection.PlayReady.IPlayReadyContentHeader2
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Media.Protection.PlayReady
{
  [ExclusiveTo(typeof (PlayReadyContentHeader))]
  [Guid(899447284, 8576, 18828, 150, 91, 231, 84, 216, 117, 234, 178)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IPlayReadyContentHeader2 : IPlayReadyContentHeader
  {
    Guid[] KeyIds { get; }

    string[] KeyIdStrings { get; }
  }
}
