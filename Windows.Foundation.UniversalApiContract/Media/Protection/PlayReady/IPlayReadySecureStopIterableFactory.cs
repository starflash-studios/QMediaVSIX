// Decompiled with JetBrains decompiler
// Type: Windows.Media.Protection.PlayReady.IPlayReadySecureStopIterableFactory
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Media.Protection.PlayReady
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(1595867493, 16916, 19870, 129, 235, 232, 159, 157, 41, 74, 238)]
  [ExclusiveTo(typeof (PlayReadySecureStopIterable))]
  internal interface IPlayReadySecureStopIterableFactory
  {
    PlayReadySecureStopIterable CreateInstance([Range(0, 2147483647)] byte[] publisherCertBytes);
  }
}
