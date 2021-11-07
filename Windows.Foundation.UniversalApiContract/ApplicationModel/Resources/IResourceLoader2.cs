// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Resources.IResourceLoader2
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Resources
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (ResourceLoader))]
  [Guid(283864774, 33080, 18625, 188, 101, 225, 241, 66, 7, 54, 124)]
  internal interface IResourceLoader2
  {
    string GetStringForUri(Uri uri);
  }
}
