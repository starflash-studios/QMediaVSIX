// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.DataTransfer.IShareProvider
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Storage.Streams;
using Windows.UI;

namespace Windows.ApplicationModel.DataTransfer
{
  [ExclusiveTo(typeof (ShareProvider))]
  [Guid(799793190, 17470, 19674, 175, 37, 141, 129, 7, 14, 253, 128)]
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  internal interface IShareProvider
  {
    string Title { get; }

    RandomAccessStreamReference DisplayIcon { get; }

    Color BackgroundColor { get; }

    object Tag { get; set; }
  }
}
