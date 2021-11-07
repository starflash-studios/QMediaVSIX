// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.DataTransfer.IShareUIOptions
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.DataTransfer
{
  [ExclusiveTo(typeof (ShareUIOptions))]
  [ContractVersion(typeof (UniversalApiContract), 327680)]
  [Guid(1929022080, 13359, 19856, 149, 81, 42, 224, 78, 55, 104, 12)]
  internal interface IShareUIOptions
  {
    ShareUITheme Theme { get; set; }

    IReference<Rect> SelectionRect { get; set; }
  }
}
