// Decompiled with JetBrains decompiler
// Type: Windows.Management.Update.IPreviewBuildsManagerStatics
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Management.Update
{
  [Guid(1044523143, 45330, 23152, 125, 161, 151, 215, 141, 50, 170, 41)]
  [ExclusiveTo(typeof (PreviewBuildsManager))]
  [ContractVersion(typeof (UniversalApiContract), 393216)]
  internal interface IPreviewBuildsManagerStatics
  {
    PreviewBuildsManager GetDefault();

    bool IsSupported();
  }
}
