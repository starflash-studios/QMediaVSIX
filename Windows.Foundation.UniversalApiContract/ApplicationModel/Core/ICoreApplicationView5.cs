// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Core.ICoreApplicationView5
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Core
{
  [ExclusiveTo(typeof (CoreApplicationView))]
  [Guid(734041512, 36592, 17517, 158, 96, 58, 62, 4, 40, 198, 113)]
  [WebHostHidden]
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  internal interface ICoreApplicationView5
  {
    IPropertySet Properties { get; }
  }
}
