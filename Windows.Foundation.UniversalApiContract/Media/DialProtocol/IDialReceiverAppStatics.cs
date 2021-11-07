// Decompiled with JetBrains decompiler
// Type: Windows.Media.DialProtocol.IDialReceiverAppStatics
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Media.DialProtocol
{
  [ContractVersion(typeof (UniversalApiContract), 327680)]
  [ExclusiveTo(typeof (DialReceiverApp))]
  [Guid(1394096700, 19510, 19714, 178, 138, 242, 169, 218, 56, 236, 82)]
  internal interface IDialReceiverAppStatics
  {
    DialReceiverApp Current { get; }
  }
}
