// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.DataTransfer.IStandardDataFormatsStatics2
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.DataTransfer
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (StandardDataFormats))]
  [Guid(1117934836, 40310, 17128, 134, 27, 71, 194, 93, 208, 207, 113)]
  internal interface IStandardDataFormatsStatics2
  {
    string WebLink { get; }

    string ApplicationLink { get; }
  }
}
