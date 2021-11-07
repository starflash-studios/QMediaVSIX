// Decompiled with JetBrains decompiler
// Type: Windows.UI.IColorHelperStatics2
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI
{
  [ExclusiveTo(typeof (ColorHelper))]
  [Guid(618245890, 28336, 19348, 133, 92, 252, 240, 129, 141, 154, 22)]
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  internal interface IColorHelperStatics2
  {
    string ToDisplayName(Color color);
  }
}
