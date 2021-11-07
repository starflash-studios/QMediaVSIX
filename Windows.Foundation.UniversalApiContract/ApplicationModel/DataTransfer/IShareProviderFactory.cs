// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.DataTransfer.IShareProviderFactory
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Storage.Streams;
using Windows.UI;

namespace Windows.ApplicationModel.DataTransfer
{
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  [ExclusiveTo(typeof (ShareProvider))]
  [Guid(388634444, 59294, 20333, 176, 125, 18, 143, 70, 158, 2, 150)]
  internal interface IShareProviderFactory
  {
    ShareProvider Create(
      string title,
      RandomAccessStreamReference displayIcon,
      Color backgroundColor,
      ShareProviderHandler handler);
  }
}
