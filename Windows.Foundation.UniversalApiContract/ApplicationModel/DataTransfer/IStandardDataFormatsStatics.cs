// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.DataTransfer.IStandardDataFormatsStatics
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.DataTransfer
{
  [ExclusiveTo(typeof (StandardDataFormats))]
  [Guid(2127987105, 43136, 16585, 180, 237, 11, 238, 30, 21, 245, 73)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IStandardDataFormatsStatics
  {
    string Text { get; }

    string Uri { [Deprecated("Uri may be altered or unavailable for releases after Windows Phone 'OSVersion' (TBD). Instead, use WebLink or ApplicationLink.", DeprecationType.Deprecate, 65536, "Windows.Foundation.UniversalApiContract")] get; }

    string Html { get; }

    string Rtf { get; }

    string Bitmap { get; }

    string StorageItems { get; }
  }
}
