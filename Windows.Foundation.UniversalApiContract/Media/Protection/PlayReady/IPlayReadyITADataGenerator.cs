// Decompiled with JetBrains decompiler
// Type: Windows.Media.Protection.PlayReady.IPlayReadyITADataGenerator
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.Media.Protection.PlayReady
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(608463758, 4281, 17712, 178, 91, 144, 26, 128, 41, 169, 178)]
  [ExclusiveTo(typeof (PlayReadyITADataGenerator))]
  internal interface IPlayReadyITADataGenerator
  {
    byte[] GenerateData(
      Guid guidCPSystemId,
      uint countOfStreams,
      IPropertySet configuration,
      PlayReadyITADataFormat format);
  }
}
