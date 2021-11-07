// Decompiled with JetBrains decompiler
// Type: Windows.Media.IVideoDisplayProperties2
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.Media
{
  [ExclusiveTo(typeof (VideoDisplayProperties))]
  [Guid(3021005262, 43858, 16811, 164, 134, 204, 16, 250, 177, 82, 249)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IVideoDisplayProperties2
  {
    IVector<string> Genres { get; }
  }
}
